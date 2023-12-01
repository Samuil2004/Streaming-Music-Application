using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Day_1___Streaming_Music_Application
{
    internal class Playlist
    {
        private string name { get; set; }
        private List<Song> songs;

        public Playlist(string Name)
        {
            this.name = Name;
            this.songs = new List<Song>();
        }
        public string GetName()
        {
            return this.name;
        }

        public List<Song> GetSongs()
        {
            return this.songs;
        }
        
        public void AddSong(Song song)
        {
            this.songs.Add(song);
        }
    }
}
