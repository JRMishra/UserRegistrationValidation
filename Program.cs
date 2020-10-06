using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Form");
            Console.WriteLine("=================================");

            User user = new User();
            user.VerifyFirstName();

            Console.WriteLine("First Name " + user.FirstName);
        }
    }
}
