using BLL.BOs;
using BLL.Services;
using PresentationLayer.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class StaffController : ApiController
    {
        [ValidStaff]
        [Route("api/staff/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = StaffServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/staff/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = StaffServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/staff/create")]
        [HttpPost]
        public HttpResponseMessage Create(StaffModel n)
        {
            var data = StaffServices.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/staff/update")]
        [HttpPost]
        public HttpResponseMessage Update(StaffModel n)
        {
            var data = StaffServices.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/staff/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = StaffServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
