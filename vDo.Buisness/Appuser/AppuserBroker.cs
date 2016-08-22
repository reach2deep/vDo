using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vDo.Data;
using vDo.Entity.Admin.Appuser;

namespace vDo.Buisness.Appuser
{
    public class AppuserBroker
    {
        public IEnumerable<AppuserEntity> GetAllData()
        {
            var entities=new Entities();

            var items = from users in entities.Appusers
                        select new AppuserEntity()
                            {
                                Id = users.Id,
                                Username = users.Username,
                                Password = users.Password
                            };
            return items.AsEnumerable();
        }

        public IEnumerable<AppuserEntity> SearchData(string searchText)
        {
            var entities = new Entities();

            var items = from users in entities.Appusers
                        where users.Username.Contains(searchText)
                        select new AppuserEntity()
                        {
                            Id = users.Id,
                            Username = users.Username,
                            Password = users.Password
                        };
            return items.AsEnumerable();
        }

        public AppuserEntity GetDetailByID(long Id)
        {
            var entities = new Entities();

            var items = from users in entities.Appusers
                        where users.Id==Id
                        select new AppuserEntity()
                        {
                            Id = users.Id,
                            Username = users.Username,
                            Password = users.Password
                        };
            return items.FirstOrDefault();
        }
    }
}
