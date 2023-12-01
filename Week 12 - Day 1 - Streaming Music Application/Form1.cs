using System.Diagnostics.Eventing.Reader;

namespace Week_12___Day_1___Streaming_Music_Application
{
    public partial class Form1 : Form
    {
        StreamingMusicService musicService;

        public Form1()
        {
            InitializeComponent();
            musicService = new StreamingMusicService("Geroge");

            foreach (Song.Genre genre in Enum.GetValues(typeof(Song.Genre)))
            {
                cbGenre.Items.Add(genre);
            }
            lbAllSongs.Items.Add("No added songs");
            lbAllUsers.Items.Add("No users added");
            lbFavoriteSongs.Items.Add("No email inputed");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpViewAllSongs)
            {
                lbAllSongs.Items.Clear();
                Song[] songs = musicService.GetSongs();
                if (songs != null && songs.Length >= 1)
                {
                    foreach (Song song in songs)
                    {
                        lbAllSongs.Items.Add(song.GetInfo());
                    }
                }
                else
                {
                    lbAllSongs.Items.Add("No added songs");
                }
            }
            else if (tabControl1.SelectedTab == tpViewAllUsers)
            {
                lbAllUsers.Items.Clear();
                User[] allUsers = musicService.GetUsers();
                if (allUsers != null && allUsers.Length >= 1)
                {
                    foreach (User user in allUsers)
                    {
                        lbAllUsers.Items.Add(musicService.GetUser(user));
                    }
                }
                else
                {
                    lbAllUsers.Items.Add("No added users");
                }
            }
            else if (tabControl1.SelectedTab == tpAddToFavorites)
            {
                cbRemoeOrAddToFavorites.Items.Clear();
                Song[] songs = musicService.GetSongs();
                if (songs != null && songs.Length >= 1)
                {
                    foreach (Song song in songs)
                    {
                        cbRemoeOrAddToFavorites.Items.Add(song.GetInfo());
                    }
                }
                else
                {
                    cbRemoeOrAddToFavorites.Items.Add("No added songs");
                }
            }
            else if (tabControl1.SelectedTab == tpPlaylists)
            {
                cbAllSongs.Items.Clear();
                Song[] songs = musicService.GetSongs();
                if (songs != null && songs.Length >= 1)
                {
                    foreach (Song song in songs)
                    {
                        cbAllSongs.Items.Add(song.GetInfo());
                    }
                }
                else
                {
                    cbAllSongs.Items.Add("No added songs");
                }
            }
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtist.Text) && !string.IsNullOrEmpty(tbTitle.Text) && Convert.ToInt32(nmDuration.Value) != 0 && !string.IsNullOrEmpty(cbGenre.SelectedItem.ToString()))
            {
                if (musicService.SongChecker(tbTitle.Text))
                {
                    musicService.AddSong(tbArtist.Text, tbTitle.Text, Convert.ToInt32(nmDuration.Value), cbGenre.SelectedItem.ToString());
                    tbArtist.Clear();
                    tbTitle.Clear();
                    nmDuration.ResetText();
                    cbGenre.ResetText();
                    MessageBox.Show("Song added succssfully");
                }
                else
                {
                    MessageBox.Show("Song with such title already exists");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all data");
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNameUserInput.Text) && !string.IsNullOrEmpty(tbEmailUserInput.Text) && !string.IsNullOrEmpty(tbAdressUserInput.Text))
            {
                musicService.AddUser(tbNameUserInput.Text, tbEmailUserInput.Text, tbAdressUserInput.Text);
                tbNameUserInput.Clear();
                tbEmailUserInput.Clear();
                tbAdressUserInput.Clear();
                MessageBox.Show("User added succssfully");
            }
            else if (!string.IsNullOrEmpty(tbNameUserInput.Text) && !string.IsNullOrEmpty(tbEmailUserInput.Text))
            {
                musicService.AddUser2(tbNameUserInput.Text, tbEmailUserInput.Text);
                tbNameUserInput.Clear();
                tbEmailUserInput.Clear();
                MessageBox.Show("User added succssfully");
            }
            else
            {
                MessageBox.Show("Please fill in all data");
            }
        }

        private void AddToFavoritesButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbRemoeOrAddToFavorites.SelectedItem.ToString()))
            {
                string selectedSong = cbRemoeOrAddToFavorites.SelectedItem.ToString();
                if (!lbFavoriteSongs.Items.Contains(selectedSong))
                {
                    lbFavoriteSongs.Items.Clear();
                    foreach (Song song in musicService.AddSongToFavorites(tbUserEmailFavoritesPage.Text, cbRemoeOrAddToFavorites.SelectedItem.ToString()))
                    {
                        lbFavoriteSongs.Items.Add(song.GetInfo());
                    }
                    cbRemoeOrAddToFavorites.ResetText();
                }
                else
                {
                    MessageBox.Show("This song is already in the list");
                }
            }
            else
            {
                MessageBox.Show("Please select a song");
            }
        }

        private void RemoveFromFavoritesButton_Click(object sender, EventArgs e)
        {
            if (cbRemoeOrAddToFavorites.SelectedItem != null)
            {
                int selectedIndex = lbFavoriteSongs.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < lbFavoriteSongs.Items.Count)
                {
                    lbFavoriteSongs.Items.Clear();
                    foreach (Song song in musicService.RemoveSongFromFavorites(tbUserEmailFavoritesPage.Text, selectedIndex))
                    {
                        lbFavoriteSongs.Items.Add(song.GetInfo());
                    }
                    cbRemoeOrAddToFavorites.ResetText();
                }
                else
                {
                    MessageBox.Show("Please select a song to remove.");
                }
            }
        }

        private void SubmitEmailButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserEmailFavoritesPage.Text))
            {
                lbFavoriteSongs.Items.Clear();
                foreach (User user in musicService.GetUsers())
                {
                    if (user.GetEmail() == tbUserEmailFavoritesPage.Text)
                    {
                        if (user.GetFavoriteSongs().Count > 0)
                        {
                            lbFavoriteSongs.Items.Clear();
                            foreach (Song song in user.GetFavoriteSongs())
                            {
                                lbFavoriteSongs.Items.Add(song.GetInfo());
                            }
                        }
                        else
                        {
                            lbFavoriteSongs.Items.Add($"{tbUserEmailFavoritesPage.Text} has no favorite songs");
                        }
                    }
                }
            }
        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            GetInfoLabel.Text = musicService.GetInfo();
        }

        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPlaylistName.Text) && !string.IsNullOrEmpty(tbUserEmailPlaylist.Text))
            {
                musicService.AddUserPlaylist(tbUserEmailPlaylist.Text, tbPlaylistName.Text);
                cbAllPlaylists.Items.Clear();
                List<Playlist> playlists = musicService.GetPlaylistList(tbUserEmailPlaylist.Text);
                foreach (Playlist playlist in playlists)
                {
                    cbAllPlaylists.Items.Add(playlist.GetName());
                }
                cbAllPlaylists.ResetText();
            }
            else
            {
                MessageBox.Show("Please input the user Email and the Playlist name");
            }
        }

        private void AddSongToPlaylistButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbAllPlaylists.SelectedItem.ToString()) && !string.IsNullOrEmpty(tbUserEmailPlaylist.Text) && !string.IsNullOrEmpty(cbAllSongs.SelectedItem.ToString()))
            {
                Song song1 = musicService.songChecker(cbAllSongs.SelectedItem.ToString());
                musicService.AddSongToPlaylist(tbUserEmailPlaylist.Text, cbAllPlaylists.SelectedItem.ToString(), song1);
            }
            else
            {
                MessageBox.Show("Please input the user Email and the Playlist name");
            }
        }

        private void ShowPlaylistButton_Click(object sender, EventArgs e)
        {
            lbPlaylistSongs.Items.Clear();
            foreach (Song song in musicService.GetSongsInPlaylist(tbUserEmailPlaylist.Text, cbAllPlaylists.SelectedItem.ToString()))
            {
                lbPlaylistSongs.Items.Add(song.GetInfo());
            }
        }

        private void SubmitUserEmailPlaylistsButton_Click(object sender, EventArgs e)
        {
            cbAllPlaylists.ResetText();
            cbAllSongs.ResetText();
            lbPlaylistSongs.Items.Clear();
            tbPlaylistName.Clear();
            cbAllPlaylists.Items.Clear();
            List<Playlist> playlists = musicService.GetPlaylistList(tbUserEmailPlaylist.Text);
            foreach (Playlist playlist in playlists)
            {
                cbAllPlaylists.Items.Add(playlist.GetName());
            }
        }
    }
}