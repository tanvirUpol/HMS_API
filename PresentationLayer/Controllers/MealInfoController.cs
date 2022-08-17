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
    public class MealInfoController : ApiController
    {

        [Route("api/meal/get")]
        [HttpGet]


        public HttpResponseMessage Get()
        {
            var data = MealInfoServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }




        [Route("api/meal/Create")]
        [HttpPost]
        public HttpResponseMessage Create(MealInfoModel m)
        {
            var data = MealInfoServices.Create(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }




        [Route("api/meal/update")]
        [HttpPost]
        public HttpResponseMessage Update(MealInfoModel m)
        {
            var data = MealInfoServices.Update(m);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/meal/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = MealInfoServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

    }
}
