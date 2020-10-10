﻿using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Form");
            Console.WriteLine("=================================");

            User user = new User();

            user.StoreFirstName();
            user.StoreLastName();
            user.StoreEmail();  
            user.StorePhoneNumber();
            user.StorePassword();

            Console.WriteLine("\nName : " + user.FirstName+" "+user.LastName);
            Console.WriteLine("Email : " + user.EMail);
            Console.WriteLine("Ph. Number : +" + user.PhoneNumber);
            
            user.VerifiedEmailList();
            Console.ReadKey();
        }
    }
}