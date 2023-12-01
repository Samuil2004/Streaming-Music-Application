using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Day_1___Streaming_Music_Application
{
    internal class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> allUsers = new List<User>();


        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
        }

        public void AddSong(string artist, string title, int durationInSeconds, string genre)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, genre));
            this.songIdSeeder++;
        }

        public bool SongChecker(string title)
        {
            foreach (Song song in songs)
            {
                if(song.GetTitle().Equals(title))
                {
                    return false;
                }
            }
            return true;
        }
        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }

        public Song[] GetSongs()
        {
            if (this.songs.Count > 0)
            {
                return this.songs.ToArray();
            }
            else
            {
                return null;
            }
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if (artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }


        public List<Song> AddSongToFavorites(string UserEmail, string selectedSong)
        {
            List<Song> favorites = new List<Song>();
            foreach (User user in allUsers)
            {
                if (user.GetEmail().Equals(UserEmail))
                {
                    foreach (Song song in GetSongs())
                    {
                        if (song.GetInfo().Equals(selectedSong))
                        {
                            user.AddSongToFavorites(song);
                            foreach(Song favouriteSong in user.GetFavoriteSongs())
                            {
                                favorites.Add(favouriteSong);
                            }
                        }
                    }
                }
            }
            return favorites;
        }

        public List<Song> RemoveSongFromFavorites(string UserEmail, int selectedSong)
        {
            List<Song> favorites = new List<Song>();
            foreach(User user in allUsers)
            {
                if(user.GetEmail().Equals(UserEmail))
                {
                    List<Song> favorites1 = user.GetFavoriteSongs();

                    user.RemoveSongFromFavorites(selectedSong);
                    foreach (Song favouriteSong in user.GetFavoriteSongs())
                    {
                        favorites.Add(favouriteSong);
                    } 
                }
            }
            return favorites;
        }

        public void AddUser(string Name, string Email, string Adress)
        {
            User newUser = new User(Name,Email,Adress);
            allUsers.Add(newUser);
        }
        public void AddUser2(string Name, string Email)
        {
            User newUser = new User(Name, Email);
            allUsers.Add(newUser);
        }

        public string GetUser(User user)
        {
            return user.GetInfo();
        }

        public User[] GetUsers()
        {
            return allUsers.ToArray();
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs and {allUsers.Count} users )";
        }

        public void AddUserPlaylist(string userEmail, string playlistName)
        { 
            foreach (User user in allUsers)
            {
                if (user.GetEmail() == userEmail)
                {
                    user.CreatePlaylist(playlistName);
                }
            }
        }

        public void AddSongToPlaylist(string userEmail, string playlistName, Song song)
        {
            foreach (User user in allUsers)
            {
                if (user.GetEmail() == userEmail)
                {
                    user.AddSongToPlaylist(playlistName, song);
                }
            }
        }

        public Song songChecker(string data)
        {
            foreach(Song song in songs)
            {
                if(data.Contains(song.GetInfo()))
                {
                    return song;
                }
            }
            return null;
        }

        public List<Playlist> GetPlaylistList(string userEmail)
        {
            foreach (User user in allUsers)
            {
                if (user.GetEmail().Equals(userEmail))
                {
                    return user.PlaylistsPrinter();
                }
            }
            return null;
        }

        public List<Song> GetSongsInPlaylist(string userEmail, string playlistName)
        {
            List<Song> songList = new List<Song>();
            foreach (User user in allUsers)
            {
                if (user.GetEmail() == userEmail)
                {
                    
                    foreach(Playlist playlist in user.PlaylistsPrinter())
                    {
                        if(playlist.GetName().Equals(playlistName))
                        {
                            foreach(Song song in user.SongsInPlaylistPrinter(playlistName))
                            {
                                songList.Add(song);
                            }
                        }
                    }
                }
            }
            return songList;
        }
    }
}
