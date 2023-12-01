using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Day_1___Streaming_Music_Application
{
    internal class Song
    {
        private int id;
        private string artist;
        private string title;
        private int durationInSeconds;
        private string genre;

        public enum Genre
        {
            Classic,
            Dance,
            Pop,
            Rock,
        }

        public Song(int id, string artist, string title, int durationInSeconds, string genre)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            this.genre = genre;
        }

        public int GetId()
        { return this.id; }

        public string GetArtist()
        { return this.artist; }

        public string GetFormattedDuration()
        {
            int minutes = durationInSeconds / 60;
            int seconds = durationInSeconds % 60;

            return $"{minutes:00}:{seconds:00}";
        }

        public string GetInfo()
        {
            return $"ID {this.id:00}: {this.artist} - {this.title} ({GetFormattedDuration()})";
        }

        public string GetTitle()
        {
            return this.title;
        }

    }
}
