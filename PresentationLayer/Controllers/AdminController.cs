using BLL.BOs;
using BLL.Services;
using PresentationLayer.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PresentationLayer.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminController : ApiController
    {
        [ValidAdmin]
        [Route("api/admin/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/admin/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/create")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel n)
        {
            var data = AdminService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminModel n)
        {
            var data = AdminService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/admin/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdminService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
