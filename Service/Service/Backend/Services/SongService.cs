using Service.Backend.Entity;
using Service.Backend.Repository;
using System;

namespace Service.Backend.Services
{
    public class SongService
    {
        private readonly Repository.SongRepository songRepository;

        public SongService(Repository.SongRepository repository)
        {
            songRepository = repository;
        }

        public void AddSong(Entity.Song song)
        {
            if (!songRepository.AddSong(song))
                throw new InvalidOperationException("Song could not be added, possibly because the ID already exists.");
        }

        public void DeleteSong(int songId)
        {
            if (!songRepository.DeleteSong(songId))
                throw new InvalidOperationException("Song could not be deleted, possibly because it does not exist.");
        }

        public void UpdateSong(Entity.Song song, int songId)
        {
            if (!songRepository.UpdateSong(song, songId))
                throw new InvalidOperationException("Song could not be updated, possibly because it does not exist.");
        }

        public Entity.Song GetSongById(int songId)
        {
            var song = songRepository.GetSongById(songId);
            if (song == null)
                throw new InvalidOperationException("No song found with the provided ID.");
            return song;
        }
    }
}