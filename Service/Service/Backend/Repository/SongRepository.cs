using Service.Backend.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Service.Backend.Repository
{
    public class SongRepository
    {
        private readonly ApplicationDbContext _context;

        public SongRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddSong(Song song)
        {
            if (_context.Songs.Any(s => s.SongId == song.SongId))
                return false;
            _context.Songs.Add(song);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteSong(string songId)
        {
            var song = _context.Songs.FirstOrDefault(s => s.SongId == songId);
            if (song == null)
                return false;
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSong(Song givenSong, string songId)
        {
            var song = _context.Songs.FirstOrDefault(s => s.SongId == songId);
            if (song == null)
                return false;
            song.Title = givenSong.Title;
            song.Album = givenSong.Album;
            song.Artist = givenSong.Artist;
            song.Path = givenSong.Path;
            _context.SaveChanges();
            return true;
        }

        public Song GetSongById(string songId)
        {
            return _context.Songs.FirstOrDefault(s => s.SongId == songId);
        }
    }
}
