using UserVerificaionSystem_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserVerficationSystem_DL
{
    public class UserData
    {
        List<User> dummyUsers = new List<User>();

        public UserData()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {


            User user1 = new User { username = "@Vanessa1" };
            User user2 = new User { username = "@Vanessa2" };
            User user3 = new User { username = "@Vanessa3" };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }
        public User GetUser(string username)
        {
            User foundUser = new User();

            foreach (var user in dummyUsers)
            {
                if (user.username == username)
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }
    }
}
