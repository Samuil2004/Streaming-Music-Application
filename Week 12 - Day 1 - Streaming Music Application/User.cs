using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Day_1___Streaming_Music_Application
{
    internal class User
    {
        private const int MAX_SONGS_IN_FAVOURITES = 50;
        private string name;
        private string email;
        private string adress;
        private List<Song> favoriteSongs;
        private List<Playlist> playlists;

        public User(string Name, string Email) 
        {
            this.name = Name;
            this.email = Email;
            this.favoriteSongs = new List<Song> ();
            this.playlists = new List<Playlist> ();
        }

        public User(string Name, string Email, string Adress)
        {
            this.name = Name;
            this.email = Email;
            this.adress = Adress;
            this.favoriteSongs = new List<Song>();
            this.playlists = new List<Playlist> ();
        }

        public void AddSongToFavorites(Song song)
        {
            if (favoriteSongs.Count < MAX_SONGS_IN_FAVOURITES || favoriteSongs != null)
            {
                favoriteSongs.Add(song);
            }
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void RemoveSongFromFavorites(int song)
        {
            if (song >= 0 && song < favoriteSongs.Count)
            {
                favoriteSongs.RemoveAt(song);
            }
        }

        public List<Song> GetFavoriteSongs()
        {
            List<Song> listFavoriteSongs = new List<Song>();

            if (favoriteSongs != null && favoriteSongs.Count > 0)
            {
                foreach (Song song in favoriteSongs)
                {
                    listFavoriteSongs.Add(song);
                }
            }
            return listFavoriteSongs;
        }


        public string GetInfo()
        {
            return $"{this.name} - {this.email} - {this.adress}";
        }

        public void CreatePlaylist(string playlistName)
        {
            Playlist playlist = new Playlist(playlistName);
            playlists.Add(playlist);
        }

        public void AddSongToPlaylist(string playlistName, Song song)
        {
            foreach (Playlist existingPlaylist in playlists)
            {
                if (existingPlaylist.GetName() == playlistName)
                {
                    existingPlaylist.AddSong(song);
                }
            }
        }

        public List<Playlist> PlaylistsPrinter()
        {
            return playlists;
        }

        public List<Song> SongsInPlaylistPrinter(string playlistName)
        {
            List<Song> listWithSongs = new List<Song>();
            foreach (Playlist playlist in playlists)
            {
                if(playlist.GetName() == playlistName)
                {
                    foreach(Song song in playlist.GetSongs())
                    {
                        listWithSongs.Add(song);
                    }
                }
            }
            return listWithSongs;
        }
    }
}
