using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.WebApp.Abstract;

namespace Vic.SportsStore.WebApp.Concrete
{
    public class DbAuthProvider : IAuthProvider
    {
        public EFDbContext EFDbContext { get; set; }

        public bool Authenticate(string username, string password)
        {
            var result = false;

            var loginUser = EFDbContext
                .LoginUsers
                .FirstOrDefault(x => x.Username == username);

            if (loginUser != null)
            {
                if (loginUser.PasswordHash == CalculateHash(password))
                {
                    result = true;
                }
            }

            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }

            return result;
        }

        private string CalculateHash(string password)
        {
            return password;
        }
    }

}