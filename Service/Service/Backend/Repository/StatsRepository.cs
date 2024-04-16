using Service.Backend.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Service.Backend.Repository
{
    public class StatsRepository
    {
        private readonly ApplicationDbContext _context;

        public StatsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddStat(Stats stat)
        {
            if (_context.Stats.Any(s => s.StatsId == stat.StatsId))
                return false;
            _context.Stats.Add(stat);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStat(int statsId)
        {
            var stat = _context.Stats.FirstOrDefault(s => s.StatsId == statsId);
            if (stat == null)
                return false;
            _context.Stats.Remove(stat);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateStat(Stats givenStat, int statsId)
        {
            var stat = _context.Stats.FirstOrDefault(s => s.StatsId == statsId);
            if (stat == null)
                return false;
            stat = givenStat;
            _context.SaveChanges();
            return true;
        }

        public Stats GetStatById(int statsId)
        {
            return _context.Stats.FirstOrDefault(s => s.StatsId == statsId);
        }
    }
}