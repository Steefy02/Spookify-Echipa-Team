using Service.Backend.Entity;
using Service.Backend.Repository;
using System;

namespace Service.Backend.Services
{
    public class StatsService
    {
        private readonly Repository.StatsRepository statRepository;

        public StatsService(Repository.StatsRepository repository)
        {
            statRepository = repository;
        }

        public void AddStat(Entity.Stats stats)
        {
            if (!statRepository.AddStat(stats))
                throw new InvalidOperationException("Stat could not be added, possibly because the ID already exists.");
        }

        public void DeleteStat(int statsId)
        {
            if (!statRepository.DeleteStat(statsId))
                throw new InvalidOperationException("Stat could not be deleted, possibly because it does not exist.");
        }

        public void UpdateStat(Entity.Stats stats, int statsId)
        {
            if (!statRepository.UpdateStat(stats, statsId))
                throw new InvalidOperationException("Stat could not be updated, possibly because it does not exist.");
        }

        public Entity.Stats GetStatById(int statsId)
        {
            var stat = statRepository.GetStatById(statsId);
            if (stat == null)
                throw new InvalidOperationException("No stat found with the provided ID.");
            return stat;
        }
    }
}