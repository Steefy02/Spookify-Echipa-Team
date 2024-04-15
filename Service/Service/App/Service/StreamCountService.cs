using Service.App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.App.Service
{
    public class StreamCountService
    {
        private Entity.StreamCount StreamCounter;

        public void IncreaseCount()
        {
            StreamCounter.SetCounter(StreamCounter.GetCount() + 1);
        }

        public void DeleteCount()
        {
            StreamCounter.SetCounter(0);
        }



    }
}
