using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PresentationLayer.Controllers
{
    [EnableCors("*","*","*")]
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel obj)
        {
            var data = AuthService.Authenticate(obj.id, obj.Password);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if(token != null)
            {
                var data = AuthService.Logout(token);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);

        }
    }
}
