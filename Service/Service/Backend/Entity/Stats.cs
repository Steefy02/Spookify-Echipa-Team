using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Backend.Entity
{
    public class Stats
    {
        private int songId;
        private int counter;
        private int statsId;

        public Stats(int songId, int counter, int statsId)
        {
            this.songId = songId;
            this.counter = counter;
            this.statsId = statsId;
        }
        public int StatsId 
        { 
            get { return statsId; } 
            set { StatsId = value; } 
        }

        public int SongID
        {
            get { return songId; }
            set { SongID = value; }
        }

        public int Counter
        {
            get { return counter; }
            set { Counter = value; }
        }





    }
}
