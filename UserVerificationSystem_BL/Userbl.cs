using UserVerficationSystem_DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserVerificationSystem_BL
{
    public class Userbl
    {
        public bool VerifyUser(string username)
        {
            UserData dataservice = new UserData();
            var result = dataservice.GetUser(username);
            return result.username != null ? true : false;

        }

    }
}
