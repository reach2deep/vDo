using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vDo.Buisness.Appuser;
using vDo.Buisness.Security;
using vDo.Entity.Admin.Appuser;

namespace vDo.Server.Controllers
{
    [CustomAuthorize]
    public class AppuserController : ApiController
    {
        // GET api/appuser
        public IEnumerable<AppuserEntity> Get()
        {
            AppuserBroker appuser= new AppuserBroker();
            return  appuser.GetAllData();
        }

        // GET api/appuser/5
        public AppuserEntity Get(long id)
        {
            AppuserBroker appuser = new AppuserBroker();
            return appuser.GetDetailByID(id);
        }

        // POST api/appuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/appuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/appuser/5
        public void Delete(int id)
        {
        }
    }
}
