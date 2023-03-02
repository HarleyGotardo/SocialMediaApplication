using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplication
{
    public class Profile : User
    {
        public Profile(string username, string password, string email, string phoneNumber, string firstName, string lastName, int age, DateOnly birthDate, string status) : base(username, password, email, phoneNumber, firstName, lastName, age, birthDate, status)
        {
        }
    }
}
