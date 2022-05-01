using Bussines_Entity.Login.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Login
{
    public interface ILoginBL
    {
        bool AuthenticateUser(userLogin userData);
      
    }
}
