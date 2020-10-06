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
            user.VerifyLastName();

            Console.WriteLine("\nName : " + user.FirstName+" "+user.LastName);
        }
    }
}
