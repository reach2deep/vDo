﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vDo.Data;

namespace vDo.Buisness.Security
{
    public class AuthenticationBroker
    {
        private readonly Entities _entities;

        public AuthenticationBroker()
        {
            _entities = new Entities();
        }

        public bool ValidateToken(string token)
        {
            var result = _entities.Appusers.SingleOrDefault(x => x.SessionId == token);
            if (result != null && result.ExpiredAt > DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public string AuthenticateMe(string uName, string pwd)
        {
            var user = _entities.Appusers.SingleOrDefault(x => x.Username == uName && x.Password == pwd);
            if (user != null)
            {
                if (user.SessionId != null && user.ExpiredAt > DateTime.Now)
                {
                    return user.SessionId;
                }
                else
                {
                    user.SessionId = Guid.NewGuid().ToString();
                    user.ExpiredAt = DateTime.Now.AddDays(1);
                    _entities.SaveChanges();
                    return user.SessionId;
                }

            }
            return string.Empty;
        }
    }
}
