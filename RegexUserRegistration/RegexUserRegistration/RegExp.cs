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
        const string email = "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
        const string mobileNo = "^([+]*)(91 )[6-9]{1}[0-9]{9}$";
        //const string password1 = "^[0-9A-Za-z]{8,}$";          /minimum 8 charactor
        //const string password2 = "^(?=.*[A-Z]).{8,}$";        /should have at least 1 upper case
        //const string password3 = "^(?=.*[0-9])(?=.*[A-Z]).{8,}$"; //should have at least 1 numeric value
        const string password4 = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
        const string sample = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";


        public string RegexFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, fname))
            {
                Console.WriteLine("First name is valid");
                return "Valid";
            }
            Console.WriteLine("First name is not valid");
            return "Invalid";
        }

        public string RegexLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, lname))
            {
                Console.WriteLine("Last name is valid");
                return "Valid";
            }
            Console.WriteLine("Last name is not valid");
            return "Invalid";
        }

        public string RegexEmail(string Email)
        {
            if (Regex.IsMatch(Email, email))
            {
                Console.WriteLine("Email is valid");
                return "Valid";
            }
            Console.WriteLine("Email is not valid");
            return "Invalid";
        }

        public string RegexMobileNo(string mobNo)
        {
            if (Regex.IsMatch(mobNo, mobileNo))
            {
                Console.WriteLine("Mobile number is valid");
                return "Valid";
            }
            Console.WriteLine("Mobile number is not valid");
            return "Invalid";
        }

        public string RegexPassword(string pwd)
        {
            if (Regex.IsMatch(pwd, password4))
            {
                Console.WriteLine("Your Password is Valid");
                return "Valid";
            }
            Console.WriteLine("Your Password is not Valid");
            return "Invalid";
        }

        public string RegexSampleMail(string SAMPLE)
        {
            if (Regex.IsMatch(SAMPLE, sample))
            {
                Console.WriteLine("Your Email is Valid");
                return "Valid";
            }
            Console.WriteLine("Your Email is not Valid");
            return "Invalid";
        }
    }
}
