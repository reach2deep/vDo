using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using vDo.Buisness.Security;
using vDo.Entity.Admin.Appuser;

namespace vDo.Server
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (AuthorizeRequest(actionContext))
            {
                return;
            }
            HandleUnauthorizedRequest(actionContext);
        }
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //Code to handle unauthorized request
            throw new HttpResponseException(HttpStatusCode.Unauthorized);

        }
        private bool AuthorizeRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            return token != null && new AuthenticationBroker().ValidateToken(token.ToString());
        }
    } 
}