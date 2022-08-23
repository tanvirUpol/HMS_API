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
    public class CalGroController : ApiController
    {
        [Route("api/calgro/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CalGroService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/calgro/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = CalGroService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/calgro/create")]
        [HttpPost]
        public HttpResponseMessage Create(CalGroModel n)
        {
            var data = CalGroService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/calgro/update")]
        [HttpPost]
        public HttpResponseMessage Update(CalGroModel n)
        {
            var data = CalGroService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/calgro/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = CalGroService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/calgro/total")]
        [HttpGet]
        public HttpResponseMessage Total()
        {
            var data = CalGroService.TotalBazar();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}

