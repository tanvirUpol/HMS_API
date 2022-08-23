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
    public class ReqestServiceController : ApiController
    {
        
        [ValidMember]
        [Route("api/rq/get")]
        [HttpGet]


        public HttpResponseMessage Get()
        {
            var data = RequestServServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }



        [ValidMember]
        [Route("api/rq/Create")]
        [HttpPost]
        public HttpResponseMessage Create(RequestServiceModel m)
        {
            var data = RequestServServices.Create(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        [ValidMember]
        [Route("api/rq/update")]
        [HttpPost]
        public HttpResponseMessage Update(RequestServiceModel m)
        {
            var data = RequestServServices.Update(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [ValidMember]
        [Route("api/rq/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = RequestServServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
