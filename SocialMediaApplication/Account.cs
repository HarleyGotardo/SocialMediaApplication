using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplication
{
    public abstract class Account
    {
        public string Username { get; set; }
        public string Password { private get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public Account(string username, string password, string email, string phoneNumber)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }
    }
}
