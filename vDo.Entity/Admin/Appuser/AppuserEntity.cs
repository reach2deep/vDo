using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vDo.Entity.Admin.Appuser
{
    public class AppuserEntity :BaseEntity 
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
