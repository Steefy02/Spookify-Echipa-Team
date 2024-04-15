using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.App.Entity
{
    public class StreamCount
    {
        private User user;
        private int Counter;

        public StreamCount(User user, int counter)
        {
            this.user = user;
            this.Counter = counter;

        }
        public int GetCount() 
        {
            return Counter;  
        }

        public void SetCounter(int counter)
        {
            Counter = counter;
        }

        


    }
}
