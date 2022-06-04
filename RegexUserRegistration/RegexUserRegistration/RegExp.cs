﻿using System;
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
        const string email = "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
        const string mobileNo = "^[0-9]{1,3}[][789][0-9]{9}$";
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

        public void RegexEmail(string Email)
        {
            if (Regex.IsMatch(Email, email))
            {
                Console.WriteLine("Email is valid");
                return;
            }
            Console.WriteLine("Email is not valid");
        }
    }
}
