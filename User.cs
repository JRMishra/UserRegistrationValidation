using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        string _firstName;
        string _lastName;
        string _regex="";

        public User()
        {
            this._firstName = "";
            this._lastName = "";
        }

        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }

        public void VerifyFirstName()
        {
            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            _regex = "^[A-Z][a-z A-Z]{3,}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(fName))
                _firstName = fName;
            else
            {
                Console.WriteLine("The first name should have\n" +
                    "1. Min 3 characters\n" +
                    "2. First letter in upper case");
                VerifyFirstName();
            }
        }
        
        public void VerifyLastName()
        {
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            _regex = "^[A-Z][a-zA-Z]{3,}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(lName))
                _lastName = lName;
            else
            {
                Console.WriteLine("The last name should have\n" +
                    "1. Min 3 characters\n" +
                    "2. First letter in upper case");
                VerifyLastName();
            }
        }
    }
}