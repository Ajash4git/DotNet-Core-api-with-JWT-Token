using Bussines_Entity.Login.Modal;
using Bussiness_Logic.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb_JWT_Bearer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILoginBL _loginBLObj;
        IAutherizeBL _autherizeBLobj;
        //private readonly IConfiguration _config;
        public LoginController(ILoginBL loginBLObj,IAutherizeBL autherizeBLobj) //, IConfiguration config
        {
            _loginBLObj = loginBLObj;
            _autherizeBLobj = autherizeBLobj;
        }

        [HttpPost]
        public tokenCard CheckLogin(userLogin userData)
        {
            if (_loginBLObj.AuthenticateUser(userData))
                return _autherizeBLobj.CreateJwtToken(userData);
            else
                return _autherizeBLobj.CreateUnAuthorizedJwtToken();
        }
        [HttpGet]
        public string CheckLogin()
        {
            return "Hi;";
        }
    }
}
