using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Entities
{
    public class Member
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public int PostalCode { get; private set; }
        public string City { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        public Member(string username, string password, string firstName, string lastName, string address, int postalCode, string city, string email, string phoneNumber)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
            City = city;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
