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
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
