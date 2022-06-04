using System;

namespace RegexUserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string fname = Console.ReadLine();
            RegExp regex = new RegExp();
            regex.RegexFirstName(fname);
        }
    }
}
