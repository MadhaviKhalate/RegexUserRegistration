using System;

namespace RegexUserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Validate First Name \n2.Validate Last Name \n3.Validate Email" +
                "\n4.validate mobile number \n5.Validate password \n6.Clear All Email Samples");
            Console.WriteLine("Enter your option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter first name");
                        string fname = Console.ReadLine();
                        RegExp regexp = new RegExp(fname);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter last name");
                        string lname = Console.ReadLine();
                        RegExp regexp = new RegExp(lname);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter an Email ID");
                        string email = Console.ReadLine();
                        RegExp regexp = new RegExp(email);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter Mobile Number");
                        string mobile = Console.ReadLine();
                        RegExp regexp = new RegExp(mobile);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter your password");
                        string password = Console.ReadLine();
                        RegExp regexp = new RegExp(password);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter Sample Email");
                        string SampleEmail = Console.ReadLine();
                        RegExp regexp = new RegExp(SampleEmail);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
            }      
        }
    }
}
