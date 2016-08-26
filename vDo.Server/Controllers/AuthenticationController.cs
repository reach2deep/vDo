using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using vDo.Buisness.Security;
using vDo.Entity.Admin.Appuser;

namespace vDo.Server.Controllers
{
    public class AuthenticationController : ApiController
    {
        // POST api/appuser
        public HttpResponseMessage Post(AppuserEntity user)
        {
            if (user == null)
            {
                return this.Request.CreateResponse(HttpStatusCode.NotFound);
            }
            var result =new AuthenticationBroker().AuthenticateMe(user.Username, user.Password);
            if (result == string.Empty)
            {
                return this.Request.CreateResponse(HttpStatusCode.Unauthorized, "NOT AUTHORIZED");
            }

            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}