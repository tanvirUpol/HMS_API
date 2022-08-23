using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PresentationLayer.Auth
{
    public class ValidAdmin : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext) 
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "No Token Supplied");
            }
            else
            {
                var rs = AuthService.TokenValidity(token.ToString());
                if (rs == 2 || rs == 3 || rs == 0)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Supplied token is invalid or expired");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}