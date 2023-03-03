using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Account
    {
        public string Username { get; set; }
        public string Password { private get; set; }
        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public abstract void Post();
    }
}
