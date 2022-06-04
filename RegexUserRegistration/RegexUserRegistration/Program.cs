﻿using System;

namespace RegexUserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Validate First Name \n2.Validate Last Name \n3.Validate Email" +
                "\n4.validate mobile number");
            Console.WriteLine("Enter your option");
            int option = Convert.ToInt32(Console.ReadLine());
            RegExp regex = new RegExp();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first name");
                    string fname = Console.ReadLine();
                    regex.RegexFirstName(fname);
                    break;

                case 2:
                    Console.WriteLine("Enter last name");
                    string lname = Console.ReadLine();
                    regex.RegexLastName(lname);
                    break;

                case 3:
                    Console.WriteLine("Enter an Email ID");
                    string email = Console.ReadLine();
                    regex.RegexEmail(email);
                    break;

                case 4:
                    Console.WriteLine("Enter Mobile Number");
                    string mobile = Console.ReadLine();
                    regex.RegexMobileNo(mobile);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
            
        }
    }
}
