using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class RegExp
    {
        const string fname = "^[A-Z]{1}[a-z]{2,}$";
        const string lname = "^[A-Z]{1}[a-z]{2,}$";
        public void RegexFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, fname))
            {
                Console.WriteLine("First name is valid");
                return;
            }
            Console.WriteLine("First name is not valid");
        }

        public void RegexLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, lname))
            {
                Console.WriteLine("Last name is valid");
                return;
            }
            Console.WriteLine("Last name is not valid");
        }
    }
}
