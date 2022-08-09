using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class StaffTaskController : ApiController
    {
        [Route("api/staffTask/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = StaffTaskServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/staffTask/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = StaffTaskServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/staffTask/create")]
        [HttpPost]
        public HttpResponseMessage Create(StaffTaskModel n)
        {
            var data = StaffTaskServices.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/staffTask/update")]
        [HttpPost]
        public HttpResponseMessage Update(StaffTaskModel n)
        {
            var data = StaffTaskServices.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/staffTask/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = StaffTaskServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
