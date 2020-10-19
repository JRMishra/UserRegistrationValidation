using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Linq;

namespace UserRegistration
{
    public class User
    {
        public string FirstNamePattern { get; } = "^[A-Z][a-z A-Z]{2,}$";
        public string LastNamePattern { get; } = "^[A-Z][a-z A-Z]{2,}$";
        public string EmailPattern { get; } = "^[a-z0-9A-Z]+([-.+_][a-z0-9+-]+)*@[a-z0-9A-Z]+[.][a-z]{2,3}([.][a-z]{2,})?$";
        public string PhoneNumberPattern { get; } = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public string PasswordPattern { get; } = "((?=^.*[0-9].*$)(?=^.*[A-Z].*$)(?=^[a-zA-Z0-9]*[!@#$%&*+_]{1}[a-zA-Z0-9]*$).{8,})";

        public bool VerifyFirstName(string fName)
        {
            if (Regex.IsMatch(fName,FirstNamePattern))
                return true;
            else
            {
                string rule = "First name needs min 3 characters and first letter in upper case";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_FIRST_NAME, rule);
            }
        }

        public bool VerifyLastName(string lName)
        {
            
            if(Regex.IsMatch(lName,LastNamePattern))
                return true;
            else
            {
                string rule = "Last name needs min 3 characters and first letter in upper case";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_LAST_NAME, rule);
            }
        }

        public bool VerifyEmail(string eMail)
        {
           
            if(Regex.IsMatch(eMail,EmailPattern))
                return true;
            else
            {
                string rule = "Email id should be in \" abc.xyz@bl.co.in \" format (.xyz & .in parts optional)";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_EMAIL, rule);
            }
        }

        public bool VerifyPhNumber(string phNum)
        {
            if (Regex.IsMatch(phNum,PhoneNumberPattern))
                return true;
            else
            {
                string rule = "Phone number should have 2 digit country code followed by space separated 10 digit number";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_PHONE_NUMBER, rule);
            }
        }

        public bool VerifyPassword(string pass)
        {
            if (Regex.IsMatch(pass, PasswordPattern))
                return true;
            else
            {
                string rule = "Password needs to have min 8 characters, at least 1 upper case character, at least 1 numeric value, exactly 1 special character";
                throw new ValidationException(ValidationException.InvalidationType.INVALID_PASSWORD, rule);
            }
        }
    }
}