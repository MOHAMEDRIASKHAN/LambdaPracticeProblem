using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPracticeProblem
{
    public class PersonDetails
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string Password;

        public PersonDetails(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
