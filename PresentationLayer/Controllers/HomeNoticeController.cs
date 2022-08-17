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
    public class HomeNoticeController : ApiController
    {
        [Route("api/homenotice/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = HomeNoticeServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/homenotice/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = HomeNoticeServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/homenotice/create")]
        [HttpPost]
        public HttpResponseMessage Create(HomeNoticeModel n)
        {
            var data = HomeNoticeServices.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/homenotice/update")]
        [HttpPost]
        public HttpResponseMessage Update(HomeNoticeModel n)
        {
            var data = HomeNoticeServices.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/homenotice/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = HomeNoticeServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
