﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Raj

        //Method for first name 
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, REGEX_FIRSTNAME); 
        }

        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Roy

        // method for last name
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);

        }

        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{1,4}$"; //alam41976@gmail.com

        //Method for email address
        public bool valiadtaeEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

    }
}
