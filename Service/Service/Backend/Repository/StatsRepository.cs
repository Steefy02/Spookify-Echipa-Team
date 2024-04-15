using Service.Backend.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Service.Backend.Repository
{
    public class StatsRepository
    {
        private List<Entity.Stats> statsList = new List<Entity.Stats>();

        public StatsRepository(List<Entity.Stats> statsList)
        {
            this.statsList = statsList;
        }

        public bool AddStat(Entity.Stats stat)
        {
            if (statsList.Any(s => s.StatsId == stat.StatsId))
                return false;
            statsList.Add(stat);
            return true;
        }

        public bool DeleteStat(int statsId)
        {
            var stat = statsList.FirstOrDefault(s => s.StatsId == statsId);
            if (stat == null)
                return false;
            statsList.Remove(stat);
            return true;
        }

        public bool UpdateStat(Entity.Stats givenStat, int statsId)
        {
            var stat = statsList.FirstOrDefault(s => s.StatsId == statsId);
            if (stat == null)
                return false;
            int index = statsList.IndexOf(stat);
            statsList[index] = givenStat;
            return true;
        }

        public Entity.Stats GetStatById(int statsId)
        {
            return statsList.FirstOrDefault(s => s.StatsId == statsId);
        }
    }
}