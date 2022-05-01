using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bussines_Entity.Login.Modal
{
    public class tokenCard
    {
        public string jwtToken { get; set; }
        public string refreshToken { get; set; }
        public bool isValid { get; set; }
    }
}
