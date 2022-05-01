using Bussines_Entity.Login.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_DA.Login
{
    public class LoginDA : ILoginDA
    {
        private readonly IDictionary<string, string> users = new Dictionary<string, string>
        { {"ajash", "ajash123"},{"tempUser","tempUser"} };
        public bool AuthenticateUser(userLogin userData)
        {
            return CheckUserFromDB_temp(userData);
        }

        private bool CheckUserFromDB_temp(userLogin userData)
        {
            if(users.Any(usr=>usr.Key==userData.userName && usr.Value ==userData.userPassword ))
                return true;
            return false;
        }

    }
}
