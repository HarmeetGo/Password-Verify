
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class PasswordVerify
    {
        //checking length of the password
        public static Boolean passwordLength(String password)
        {
            int minLength = 8;
            if (password.Length < minLength)     //if length of password is less than minimum length required
            {
                Console.WriteLine("password should be larger than 8 chars");
                return false;
            }
            else
            {
                return true;
            }
        }

        //checking if pssword contains upper and lower case letter or not
        public static Boolean isUpperAndLowerCasePresent(String password)
        {
            if (!password.Any(char.IsUpper))      //if there is no upper case letter
            {
                Console.WriteLine("password should have one uppercase letter at least");
                return false;   
            }
            else if (!password.Any(char.IsLower))  //if there is no lower case letter
            {
                Console.WriteLine("password should have one lower letter at least");
                return false;
            }
            else
            {
                return true;
            }
        }

        //checking whether password contains a digit or not
        public static Boolean isDigitPresent(String password)
        {
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            String password;
            password = Console.ReadLine();
            Boolean passLength = passwordLength(password);
            Boolean upperAndLowerPresent=isUpperAndLowerCasePresent(password);
            Boolean digitPresent=isDigitPresent(password);

            
            if (passLength && upperAndLowerPresent && digitPresent)    //if all the conditions are true
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
            else                                                       //else
            {
                Console.WriteLine("Invalid");
                Console.ReadLine();
            }
        }
    }
}
