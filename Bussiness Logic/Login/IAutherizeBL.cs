using Bussines_Entity.Login.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Login
{
    public interface IAutherizeBL
    {
        tokenCard CreateJwtToken(userLogin userData);
        tokenCard CreateUnAuthorizedJwtToken();
    }
}
