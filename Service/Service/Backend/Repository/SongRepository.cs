using Service.Backend.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Service.Backend.Repository
{
    public class SongRepository
    {
        private List<Entity.Song> songList = new List<Entity.Song>();

        public SongRepository(List<Entity.Song> songList)
        {
            this.songList = songList;
        }

        public bool AddSong(Entity.Song song)
        {
            if (songList.Any(s => s.SongId == song.SongId))
                return false;
            songList.Add(song);
            return true;
        }

        public bool DeleteSong(int songId)
        {
            var song = songList.FirstOrDefault(s => s.SongId == songId);
            if (song == null)
                return false;
            songList.Remove(song);
            return true;
        }

        public bool UpdateSong(Entity.Song givenSong, int songId)
        {
            var song = songList.FirstOrDefault(s => s.SongId == songId);
            if (song == null)
                return false;
            int index = songList.IndexOf(song);
            songList[index] = givenSong;
            return true;
        }

        public Entity.Song GetSongById(int songId)
        {
            return songList.FirstOrDefault(s => s.SongId == songId);
        }
    }
}