using Bussines_DA.Login;
using Bussines_Entity.Login.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Login
{
    public class LoginBL : ILoginBL
    {
        ILoginDA _loginDAObj;

        public LoginBL(ILoginDA loginDAObj)
        {
            _loginDAObj = loginDAObj;
        }
        public bool AuthenticateUser(userLogin userData)
        {
            return _loginDAObj.AuthenticateUser(userData);
        }
    }
}
