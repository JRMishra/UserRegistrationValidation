﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class User
    {
        string _firstName;
        string _lastName;
        string _eMail;

        string _regex="";

        public User()
        {
            this._firstName = "";
            this._lastName = "";
            this._eMail = "";
        }

        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string EMail { get => _eMail; }

        public void VerifyFirstName()
        {
            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            _regex = "^[A-Z][a-z A-Z]{2,}$";
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
            _regex = "^[A-Z][a-zA-Z]{2,}$";
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
        
        public void VerifyEmail()
        {
            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();
            _regex = "^[a-z1-9]{1,}(.[a-z1-9]{1,}){0,}@[a-z]{1,}[.]{1}[a-z]{1,}(.[a-z]{1,}){0,}$";
            Regex rgxObj = new Regex(_regex);
            if (rgxObj.IsMatch(email))
                _eMail = email;
            else
            {
                Console.WriteLine("The Email Id should be in \" abc.xyz@bl.co.in \" format\n" +
                    "(xyz & in parts optional)");
                VerifyEmail();
            }
        }

    }
}