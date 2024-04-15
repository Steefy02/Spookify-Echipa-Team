using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Backend.Entity
{
    public class Song
    {
        private string filePath;
        private string artist;
        private int songId;
        private string name;
        private string album;

        public Song(string file_path, string owner_name, int file_id, string name, string album)
        {
            this.filePath = file_path;
            this.artist = owner_name;
            this.songId = file_id;
            this.name = name;
            this.album = album;
        }

        
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

       
        public int SongId
        {
            get { return songId; }
            set { songId = value; }
        }

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

      
        public string Album
        {
            get { return album; }
            set { album = value; }
        }
    }
}