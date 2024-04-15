using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.App.Entity
{
    public class User
    {
        private int UserId;
        private string UserName;

        public User(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        public string GetUserName() 
        { 
            return UserName; 
        }
        public int GetUserId()
        { 
            return UserId; 
        }

        public void SetUserName(string userName)
        {
            UserName = userName;
        }

    }
}
