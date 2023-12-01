namespace Week_12___Day_1___Streaming_Music_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpViewAllSongs = new TabPage();
            lbAllSongs = new ListBox();
            tpAddASong = new TabPage();
            AddSongButton = new Button();
            cbGenre = new ComboBox();
            GenreLabel = new Label();
            nmDuration = new NumericUpDown();
            tbTitle = new TextBox();
            tbArtist = new TextBox();
            DurationLabel = new Label();
            TitleLabel = new Label();
            ArtistLabel = new Label();
            tpViewAllUsers = new TabPage();
            GetInfoLabel = new Label();
            GetInfoButton = new Button();
            lbAllUsers = new ListBox();
            tpAddANewUser = new TabPage();
            AddUserButton = new Button();
            tbAdressUserInput = new TextBox();
            tbEmailUserInput = new TextBox();
            tbNameUserInput = new TextBox();
            AdressLabel = new Label();
            EmailAdressLabel = new Label();
            NameLabel = new Label();
            tpAddToFavorites = new TabPage();
            NotificationLabel = new Label();
            SubmitEmailButton = new Button();
            lbFavoriteSongs = new ListBox();
            tbUserEmailFavoritesPage = new TextBox();
            UserEmailAddToFavoritesLabel = new Label();
            RemoveFromFavoritesButton = new Button();
            AddToFavoritesButton = new Button();
            ChooseASongLabel = new Label();
            cbRemoeOrAddToFavorites = new ComboBox();
            tpPlaylists = new TabPage();
            SubmitUserEmailPlaylistsButton = new Button();
            tbUserEmailPlaylist = new TextBox();
            PlaylistPageUserEmailLabel = new Label();
            ShowPlaylistButton = new Button();
            AddSongToPlaylistButton = new Button();
            cbAllSongs = new ComboBox();
            cbAllPlaylists = new ComboBox();
            CreatePlaylistButton = new Button();
            tbPlaylistName = new TextBox();
            PlaylistNameLabel = new Label();
            lbPlaylistSongs = new ListBox();
            tabControl1.SuspendLayout();
            tpViewAllSongs.SuspendLayout();
            tpAddASong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDuration).BeginInit();
            tpViewAllUsers.SuspendLayout();
            tpAddANewUser.SuspendLayout();
            tpAddToFavorites.SuspendLayout();
            tpPlaylists.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpViewAllSongs);
            tabControl1.Controls.Add(tpAddASong);
            tabControl1.Controls.Add(tpViewAllUsers);
            tabControl1.Controls.Add(tpAddANewUser);
            tabControl1.Controls.Add(tpAddToFavorites);
            tabControl1.Controls.Add(tpPlaylists);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 457);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tpViewAllSongs
            // 
            tpViewAllSongs.Controls.Add(lbAllSongs);
            tpViewAllSongs.Location = new Point(8, 46);
            tpViewAllSongs.Name = "tpViewAllSongs";
            tpViewAllSongs.Padding = new Padding(3);
            tpViewAllSongs.Size = new Size(782, 403);
            tpViewAllSongs.TabIndex = 1;
            tpViewAllSongs.Text = "All Songs";
            tpViewAllSongs.UseVisualStyleBackColor = true;
            // 
            // lbAllSongs
            // 
            lbAllSongs.FormattingEnabled = true;
            lbAllSongs.Location = new Point(54, 48);
            lbAllSongs.Name = "lbAllSongs";
            lbAllSongs.Size = new Size(700, 292);
            lbAllSongs.TabIndex = 0;
            // 
            // tpAddASong
            // 
            tpAddASong.Controls.Add(AddSongButton);
            tpAddASong.Controls.Add(cbGenre);
            tpAddASong.Controls.Add(GenreLabel);
            tpAddASong.Controls.Add(nmDuration);
            tpAddASong.Controls.Add(tbTitle);
            tpAddASong.Controls.Add(tbArtist);
            tpAddASong.Controls.Add(DurationLabel);
            tpAddASong.Controls.Add(TitleLabel);
            tpAddASong.Controls.Add(ArtistLabel);
            tpAddASong.Location = new Point(8, 46);
            tpAddASong.Name = "tpAddASong";
            tpAddASong.Padding = new Padding(3);
            tpAddASong.Size = new Size(782, 403);
            tpAddASong.TabIndex = 0;
            tpAddASong.Text = "Add Song";
            tpAddASong.UseVisualStyleBackColor = true;
            // 
            // AddSongButton
            // 
            AddSongButton.Location = new Point(316, 309);
            AddSongButton.Name = "AddSongButton";
            AddSongButton.Size = new Size(150, 46);
            AddSongButton.TabIndex = 10;
            AddSongButton.Text = "Add Song";
            AddSongButton.UseVisualStyleBackColor = true;
            AddSongButton.Click += AddSongButton_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(405, 248);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(242, 40);
            cbGenre.TabIndex = 9;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(136, 251);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(83, 32);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre:";
            // 
            // nmDuration
            // 
            nmDuration.Location = new Point(407, 187);
            nmDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmDuration.Name = "nmDuration";
            nmDuration.Size = new Size(240, 39);
            nmDuration.TabIndex = 7;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(407, 121);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(200, 39);
            tbTitle.TabIndex = 6;
            // 
            // tbArtist
            // 
            tbArtist.Location = new Point(407, 56);
            tbArtist.Name = "tbArtist";
            tbArtist.Size = new Size(200, 39);
            tbArtist.TabIndex = 5;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(136, 189);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(241, 32);
            DurationLabel.TabIndex = 3;
            DurationLabel.Text = "Duration (in seconds)";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(136, 124);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(65, 32);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Title:";
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(136, 59);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(74, 32);
            ArtistLabel.TabIndex = 1;
            ArtistLabel.Text = "Artist:";
            // 
            // tpViewAllUsers
            // 
            tpViewAllUsers.Controls.Add(GetInfoLabel);
            tpViewAllUsers.Controls.Add(GetInfoButton);
            tpViewAllUsers.Controls.Add(lbAllUsers);
            tpViewAllUsers.Location = new Point(8, 46);
            tpViewAllUsers.Name = "tpViewAllUsers";
            tpViewAllUsers.Size = new Size(782, 403);
            tpViewAllUsers.TabIndex = 2;
            tpViewAllUsers.Text = "All users";
            tpViewAllUsers.UseVisualStyleBackColor = true;
            // 
            // GetInfoLabel
            // 
            GetInfoLabel.AutoSize = true;
            GetInfoLabel.Location = new Point(161, 361);
            GetInfoLabel.Name = "GetInfoLabel";
            GetInfoLabel.Size = new Size(0, 32);
            GetInfoLabel.TabIndex = 2;
            // 
            // GetInfoButton
            // 
            GetInfoButton.Location = new Point(5, 347);
            GetInfoButton.Name = "GetInfoButton";
            GetInfoButton.Size = new Size(150, 46);
            GetInfoButton.TabIndex = 1;
            GetInfoButton.Text = "Get Info";
            GetInfoButton.UseVisualStyleBackColor = true;
            GetInfoButton.Click += GetInfoButton_Click;
            // 
            // lbAllUsers
            // 
            lbAllUsers.FormattingEnabled = true;
            lbAllUsers.Location = new Point(62, 38);
            lbAllUsers.Name = "lbAllUsers";
            lbAllUsers.Size = new Size(647, 292);
            lbAllUsers.TabIndex = 0;
            // 
            // tpAddANewUser
            // 
            tpAddANewUser.Controls.Add(AddUserButton);
            tpAddANewUser.Controls.Add(tbAdressUserInput);
            tpAddANewUser.Controls.Add(tbEmailUserInput);
            tpAddANewUser.Controls.Add(tbNameUserInput);
            tpAddANewUser.Controls.Add(AdressLabel);
            tpAddANewUser.Controls.Add(EmailAdressLabel);
            tpAddANewUser.Controls.Add(NameLabel);
            tpAddANewUser.Location = new Point(8, 46);
            tpAddANewUser.Name = "tpAddANewUser";
            tpAddANewUser.Size = new Size(782, 403);
            tpAddANewUser.TabIndex = 3;
            tpAddANewUser.Text = "Add user";
            tpAddANewUser.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(284, 326);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(150, 46);
            AddUserButton.TabIndex = 6;
            AddUserButton.Text = "Add User";
            AddUserButton.UseVisualStyleBackColor = true;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // tbAdressUserInput
            // 
            tbAdressUserInput.Location = new Point(351, 216);
            tbAdressUserInput.Name = "tbAdressUserInput";
            tbAdressUserInput.Size = new Size(200, 39);
            tbAdressUserInput.TabIndex = 5;
            // 
            // tbEmailUserInput
            // 
            tbEmailUserInput.Location = new Point(351, 144);
            tbEmailUserInput.Name = "tbEmailUserInput";
            tbEmailUserInput.Size = new Size(200, 39);
            tbEmailUserInput.TabIndex = 4;
            // 
            // tbNameUserInput
            // 
            tbNameUserInput.Location = new Point(351, 71);
            tbNameUserInput.Name = "tbNameUserInput";
            tbNameUserInput.Size = new Size(200, 39);
            tbNameUserInput.TabIndex = 3;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(95, 219);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(89, 32);
            AdressLabel.TabIndex = 2;
            AdressLabel.Text = "Adress:";
            // 
            // EmailAdressLabel
            // 
            EmailAdressLabel.AutoSize = true;
            EmailAdressLabel.Location = new Point(95, 147);
            EmailAdressLabel.Name = "EmailAdressLabel";
            EmailAdressLabel.Size = new Size(76, 32);
            EmailAdressLabel.TabIndex = 1;
            EmailAdressLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(95, 74);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(83, 32);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // tpAddToFavorites
            // 
            tpAddToFavorites.Controls.Add(NotificationLabel);
            tpAddToFavorites.Controls.Add(SubmitEmailButton);
            tpAddToFavorites.Controls.Add(lbFavoriteSongs);
            tpAddToFavorites.Controls.Add(tbUserEmailFavoritesPage);
            tpAddToFavorites.Controls.Add(UserEmailAddToFavoritesLabel);
            tpAddToFavorites.Controls.Add(RemoveFromFavoritesButton);
            tpAddToFavorites.Controls.Add(AddToFavoritesButton);
            tpAddToFavorites.Controls.Add(ChooseASongLabel);
            tpAddToFavorites.Controls.Add(cbRemoeOrAddToFavorites);
            tpAddToFavorites.Location = new Point(8, 46);
            tpAddToFavorites.Name = "tpAddToFavorites";
            tpAddToFavorites.Size = new Size(782, 403);
            tpAddToFavorites.TabIndex = 4;
            tpAddToFavorites.Text = "Add to favorites";
            tpAddToFavorites.UseVisualStyleBackColor = true;
            // 
            // NotificationLabel
            // 
            NotificationLabel.AutoSize = true;
            NotificationLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotificationLabel.Location = new Point(352, 99);
            NotificationLabel.Name = "NotificationLabel";
            NotificationLabel.Size = new Size(310, 60);
            NotificationLabel.TabIndex = 8;
            NotificationLabel.Text = "*if the song is already in the list,\r\nit will not be added";
            // 
            // SubmitEmailButton
            // 
            SubmitEmailButton.Location = new Point(595, 8);
            SubmitEmailButton.Name = "SubmitEmailButton";
            SubmitEmailButton.Size = new Size(138, 37);
            SubmitEmailButton.TabIndex = 7;
            SubmitEmailButton.Text = "Submit";
            SubmitEmailButton.UseVisualStyleBackColor = true;
            SubmitEmailButton.Click += SubmitEmailButton_Click;
            // 
            // lbFavoriteSongs
            // 
            lbFavoriteSongs.FormattingEnabled = true;
            lbFavoriteSongs.Location = new Point(111, 174);
            lbFavoriteSongs.Name = "lbFavoriteSongs";
            lbFavoriteSongs.Size = new Size(622, 132);
            lbFavoriteSongs.TabIndex = 6;
            // 
            // tbUserEmailFavoritesPage
            // 
            tbUserEmailFavoritesPage.Location = new Point(352, 8);
            tbUserEmailFavoritesPage.Name = "tbUserEmailFavoritesPage";
            tbUserEmailFavoritesPage.Size = new Size(200, 39);
            tbUserEmailFavoritesPage.TabIndex = 5;
            // 
            // UserEmailAddToFavoritesLabel
            // 
            UserEmailAddToFavoritesLabel.AutoSize = true;
            UserEmailAddToFavoritesLabel.Location = new Point(111, 11);
            UserEmailAddToFavoritesLabel.Name = "UserEmailAddToFavoritesLabel";
            UserEmailAddToFavoritesLabel.Size = new Size(126, 32);
            UserEmailAddToFavoritesLabel.TabIndex = 4;
            UserEmailAddToFavoritesLabel.Text = "User email";
            // 
            // RemoveFromFavoritesButton
            // 
            RemoveFromFavoritesButton.Location = new Point(111, 322);
            RemoveFromFavoritesButton.Name = "RemoveFromFavoritesButton";
            RemoveFromFavoritesButton.Size = new Size(198, 57);
            RemoveFromFavoritesButton.TabIndex = 3;
            RemoveFromFavoritesButton.Text = "Remove";
            RemoveFromFavoritesButton.UseVisualStyleBackColor = true;
            RemoveFromFavoritesButton.Click += RemoveFromFavoritesButton_Click;
            // 
            // AddToFavoritesButton
            // 
            AddToFavoritesButton.Location = new Point(111, 111);
            AddToFavoritesButton.Name = "AddToFavoritesButton";
            AddToFavoritesButton.Size = new Size(198, 57);
            AddToFavoritesButton.TabIndex = 2;
            AddToFavoritesButton.Text = "Add";
            AddToFavoritesButton.UseVisualStyleBackColor = true;
            AddToFavoritesButton.Click += AddToFavoritesButton_Click;
            // 
            // ChooseASongLabel
            // 
            ChooseASongLabel.AutoSize = true;
            ChooseASongLabel.Location = new Point(111, 59);
            ChooseASongLabel.Name = "ChooseASongLabel";
            ChooseASongLabel.Size = new Size(177, 32);
            ChooseASongLabel.TabIndex = 1;
            ChooseASongLabel.Text = "Choose a song:";
            // 
            // cbRemoeOrAddToFavorites
            // 
            cbRemoeOrAddToFavorites.FormattingEnabled = true;
            cbRemoeOrAddToFavorites.Location = new Point(352, 56);
            cbRemoeOrAddToFavorites.Name = "cbRemoeOrAddToFavorites";
            cbRemoeOrAddToFavorites.Size = new Size(381, 40);
            cbRemoeOrAddToFavorites.TabIndex = 0;
            // 
            // tpPlaylists
            // 
            tpPlaylists.Controls.Add(SubmitUserEmailPlaylistsButton);
            tpPlaylists.Controls.Add(tbUserEmailPlaylist);
            tpPlaylists.Controls.Add(PlaylistPageUserEmailLabel);
            tpPlaylists.Controls.Add(ShowPlaylistButton);
            tpPlaylists.Controls.Add(AddSongToPlaylistButton);
            tpPlaylists.Controls.Add(cbAllSongs);
            tpPlaylists.Controls.Add(cbAllPlaylists);
            tpPlaylists.Controls.Add(CreatePlaylistButton);
            tpPlaylists.Controls.Add(tbPlaylistName);
            tpPlaylists.Controls.Add(PlaylistNameLabel);
            tpPlaylists.Controls.Add(lbPlaylistSongs);
            tpPlaylists.Location = new Point(8, 46);
            tpPlaylists.Name = "tpPlaylists";
            tpPlaylists.Size = new Size(782, 403);
            tpPlaylists.TabIndex = 5;
            tpPlaylists.Text = "Playlists";
            tpPlaylists.UseVisualStyleBackColor = true;
            // 
            // SubmitUserEmailPlaylistsButton
            // 
            SubmitUserEmailPlaylistsButton.Location = new Point(435, 23);
            SubmitUserEmailPlaylistsButton.Name = "SubmitUserEmailPlaylistsButton";
            SubmitUserEmailPlaylistsButton.Size = new Size(150, 46);
            SubmitUserEmailPlaylistsButton.TabIndex = 10;
            SubmitUserEmailPlaylistsButton.Text = "Submit";
            SubmitUserEmailPlaylistsButton.UseVisualStyleBackColor = true;
            SubmitUserEmailPlaylistsButton.Click += SubmitUserEmailPlaylistsButton_Click;
            // 
            // tbUserEmailPlaylist
            // 
            tbUserEmailPlaylist.Location = new Point(190, 23);
            tbUserEmailPlaylist.Name = "tbUserEmailPlaylist";
            tbUserEmailPlaylist.Size = new Size(200, 39);
            tbUserEmailPlaylist.TabIndex = 9;
            // 
            // PlaylistPageUserEmailLabel
            // 
            PlaylistPageUserEmailLabel.AutoSize = true;
            PlaylistPageUserEmailLabel.Location = new Point(27, 26);
            PlaylistPageUserEmailLabel.Name = "PlaylistPageUserEmailLabel";
            PlaylistPageUserEmailLabel.Size = new Size(131, 32);
            PlaylistPageUserEmailLabel.TabIndex = 8;
            PlaylistPageUserEmailLabel.Text = "User email:";
            // 
            // ShowPlaylistButton
            // 
            ShowPlaylistButton.Location = new Point(21, 332);
            ShowPlaylistButton.Name = "ShowPlaylistButton";
            ShowPlaylistButton.Size = new Size(158, 46);
            ShowPlaylistButton.TabIndex = 7;
            ShowPlaylistButton.Text = "Show";
            ShowPlaylistButton.UseVisualStyleBackColor = true;
            ShowPlaylistButton.Click += ShowPlaylistButton_Click;
            // 
            // AddSongToPlaylistButton
            // 
            AddSongToPlaylistButton.Location = new Point(21, 268);
            AddSongToPlaylistButton.Name = "AddSongToPlaylistButton";
            AddSongToPlaylistButton.Size = new Size(158, 46);
            AddSongToPlaylistButton.TabIndex = 6;
            AddSongToPlaylistButton.Text = "Add Song";
            AddSongToPlaylistButton.UseVisualStyleBackColor = true;
            AddSongToPlaylistButton.Click += AddSongToPlaylistButton_Click;
            // 
            // cbAllSongs
            // 
            cbAllSongs.FormattingEnabled = true;
            cbAllSongs.Location = new Point(387, 151);
            cbAllSongs.Name = "cbAllSongs";
            cbAllSongs.Size = new Size(376, 40);
            cbAllSongs.TabIndex = 5;
            // 
            // cbAllPlaylists
            // 
            cbAllPlaylists.FormattingEnabled = true;
            cbAllPlaylists.Location = new Point(21, 151);
            cbAllPlaylists.Name = "cbAllPlaylists";
            cbAllPlaylists.Size = new Size(320, 40);
            cbAllPlaylists.TabIndex = 4;
            // 
            // CreatePlaylistButton
            // 
            CreatePlaylistButton.Location = new Point(415, 75);
            CreatePlaylistButton.Name = "CreatePlaylistButton";
            CreatePlaylistButton.Size = new Size(244, 46);
            CreatePlaylistButton.TabIndex = 3;
            CreatePlaylistButton.Text = "Create Playlist";
            CreatePlaylistButton.UseVisualStyleBackColor = true;
            CreatePlaylistButton.Click += CreatePlaylistButton_Click;
            // 
            // tbPlaylistName
            // 
            tbPlaylistName.Location = new Point(190, 79);
            tbPlaylistName.Name = "tbPlaylistName";
            tbPlaylistName.Size = new Size(200, 39);
            tbPlaylistName.TabIndex = 2;
            // 
            // PlaylistNameLabel
            // 
            PlaylistNameLabel.AutoSize = true;
            PlaylistNameLabel.Location = new Point(21, 82);
            PlaylistNameLabel.Name = "PlaylistNameLabel";
            PlaylistNameLabel.Size = new Size(163, 32);
            PlaylistNameLabel.TabIndex = 1;
            PlaylistNameLabel.Text = "Playlist Name:";
            // 
            // lbPlaylistSongs
            // 
            lbPlaylistSongs.FormattingEnabled = true;
            lbPlaylistSongs.Location = new Point(360, 214);
            lbPlaylistSongs.Name = "lbPlaylistSongs";
            lbPlaylistSongs.Size = new Size(403, 164);
            lbPlaylistSongs.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tpViewAllSongs.ResumeLayout(false);
            tpAddASong.ResumeLayout(false);
            tpAddASong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDuration).EndInit();
            tpViewAllUsers.ResumeLayout(false);
            tpViewAllUsers.PerformLayout();
            tpAddANewUser.ResumeLayout(false);
            tpAddANewUser.PerformLayout();
            tpAddToFavorites.ResumeLayout(false);
            tpAddToFavorites.PerformLayout();
            tpPlaylists.ResumeLayout(false);
            tpPlaylists.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpAddASong;
        private TabPage tpViewAllSongs;
        private TabPage tpViewAllUsers;
        private TabPage tpAddANewUser;
        private TabPage tpAddToFavorites;
        private Label ArtistLabel;
        private Label TitleLabel;
        private Label DurationLabel;
        private TextBox tbArtist;
        private TextBox tbTitle;
        private NumericUpDown nmDuration;
        private Label GenreLabel;
        private ComboBox cbGenre;
        private Button AddSongButton;
        private ListBox lbAllSongs;
        private ListBox lbAllUsers;
        private Label NameLabel;
        private Label EmailAdressLabel;
        private Label AdressLabel;
        private TextBox tbNameUserInput;
        private TextBox tbEmailUserInput;
        private TextBox tbAdressUserInput;
        private Button AddUserButton;
        private ComboBox cbRemoeOrAddToFavorites;
        private Label ChooseASongLabel;
        private Button AddToFavoritesButton;
        private Button RemoveFromFavoritesButton;
        private Label UserEmailAddToFavoritesLabel;
        private TextBox tbUserEmailFavoritesPage;
        private ListBox lbFavoriteSongs;
        private Button SubmitEmailButton;
        private Label NotificationLabel;
        private Button GetInfoButton;
        private Label GetInfoLabel;
        private TabPage tpPlaylists;
        private ListBox lbPlaylistSongs;
        private Label PlaylistNameLabel;
        private TextBox tbPlaylistName;
        private Button CreatePlaylistButton;
        private ComboBox cbAllPlaylists;
        private ComboBox cbAllSongs;
        private Button AddSongToPlaylistButton;
        private Button ShowPlaylistButton;
        private Label PlaylistPageUserEmailLabel;
        private TextBox tbUserEmailPlaylist;
        private Button SubmitUserEmailPlaylistsButton;
    }
}
