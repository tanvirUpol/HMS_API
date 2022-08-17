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
    public class MemberController : ApiController
    {
        [Route("api/Member/get")]
        [HttpGet]


        public HttpResponseMessage Get()
        {
            var data = MemberService.GetAllMember();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Member/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = MemberService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }




        [Route("api/Member/Create")]
        [HttpPost]
        public HttpResponseMessage Create(MemberModel m)
        {
            var data = MemberService.Create(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }




        [Route("api/Member/update")]
        [HttpPost]
        public HttpResponseMessage Update(MemberModel m)
        {
            var data = MemberService.Update(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Member/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = MemberService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }






    }
}
