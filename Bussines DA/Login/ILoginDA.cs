using Bussines_Entity.Login.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines_DA.Login
{
    public interface ILoginDA
    {
        bool AuthenticateUser(userLogin userData);
    }
}
