using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/student")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
