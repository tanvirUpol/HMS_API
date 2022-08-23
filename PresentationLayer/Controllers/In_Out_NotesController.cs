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
    public class In_Out_NotesController : ApiController
    {
        [Route("api/in_out_notes/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = In_Out_NotesService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/in_out_notes/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = In_Out_NotesService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/in_out_notes/create")]
        [HttpPost]
        public HttpResponseMessage Create(In_Out_NotesModel n)
        {
            var data = In_Out_NotesService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/in_out_notes/update")]
        [HttpPost]
        public HttpResponseMessage Update(In_Out_NotesModel n)
        {
            var data = In_Out_NotesService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/in_out_notes/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = In_Out_NotesService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
