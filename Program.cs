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
            user.VerifyEmail();

            Console.WriteLine("\nName : " + user.FirstName+" "+user.LastName);
            Console.WriteLine("Email : " + user.EMail);
        }
    }
}
