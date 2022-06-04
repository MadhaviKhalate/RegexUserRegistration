using System;

namespace RegexUserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Validate First Name \n2.Validate Last Name \n ");
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

            }
            
        }
    }
}
