using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        string _firstName;

        public User()
        {
            this._firstName = "";
        }

        public string FirstName { get => _firstName; }

        public void VerifyFirstName()
        {
            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            string regex = "^[A-Z][a-z A-Z]{3,}$";
            Regex rgxObj = new Regex(regex);
            if (rgxObj.IsMatch(fName))
                _firstName = fName;
            else
            {
                Console.WriteLine("The name should have\n" +
                    "1. Min 3 characters\n" +
                    "2. First letter in upper case");
                VerifyFirstName();
            }
        }
    }
}
