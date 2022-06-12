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
        //const string password1 = "^[0-9A-Za-z]{8,}$";          /minimum 8 charactor
        //const string password2 = "^(?=.*[A-Z]).{8,}$";        /should have at least 1 upper case
        //const string password3 = "^(?=.*[0-9])(?=.*[A-Z]).{8,}$"; //should have at least 1 numeric value

        public string input;
        public RegExp(string input)
        {
            this.input = input;
        }

        public string RegexFirstName()
        {
            const string fname = "^[A-Z]{1}[a-z]{2,}$";
            Func<string, bool> result = (input) => (Regex.IsMatch(input, fname));

            if (result(input))
            {
                Console.WriteLine("First name is valid");
                return "Valid";
            }
            else
            {
               Console.WriteLine("Your First Name is Invalid...Name should start with Caps and have atleast 3 characters");
               throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid Name");
            }
        }

        public string RegexLastName()
        {
            const string lname = "^[A-Z]{1}[a-z]{2,}$";
            Func<string, bool> result = (input) => (Regex.IsMatch(input, lname));

            if (result(input))
            {
                Console.WriteLine("Last name is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Last Name is Invalid...Name should start with Caps and have atleast 3 characters");
                throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "Invalid Name");
            }
        }

        public string RegexEmail()
        {
            const string email = "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";

            if (Regex.IsMatch(input, email))
            {
                Console.WriteLine("Email is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine(input + " - is Invalid");
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }

        public string RegexMobileNo()
        {
            const string mobileNo = "^([+]*)(91 )[6-9]{1}[0-9]{9}$";
            Func<string, bool> result = (input) => (Regex.IsMatch(input, mobileNo));

            if (result(input))
            {
                Console.WriteLine("Mobile number is valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Phone Number not is Valid");
                throw new CustomException(CustomException.ExceptionType.INVALID_NUMBER, "Invalid PhoneNumber");
            }
        }

        public string RegexPassword()
        {
            const string password4 = "^[a-z A-Z 0-9]{1,}[A-Z]{1,}[a-z A-Z 0-9]{1,}[!*@#$%^&+=]?[a-z A-Z 0-9]{1,}[0-9]{1,}[a-z A-Z 0-9]{1,}$";
            Func<string, bool> result = (input) => (Regex.IsMatch(input, password4));

            if (result(input))
            {
                Console.WriteLine("Your Password is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Password is not Valid");
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }

        public string RegexSampleMail()
        {
            const string sample = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
            Func<string, bool> result = (input) => (Regex.IsMatch(input, sample));

            if (result(input))
            {
                Console.WriteLine("Your Email is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine(input + " - is Invalid");
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }
    }
}
