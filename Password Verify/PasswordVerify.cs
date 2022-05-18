
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public class PasswordVerify
    {
        //checking length of the password
        public static Boolean PasswordLength(String password)
        {
            int minLength = 8;
            try
            {
                if (password.Length < minLength)
                {
                    throw new Exception("password should be larger than 8 chars");

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }




        }

        //checking if pssword contains upper and lower case letter or not
        public static Boolean IsUpperAndLowerCasePresent(String password)
        {
            try
            {
                if (!password.Any(char.IsUpper))      //if there is no upper case letter
                {
                    throw new Exception("password should have one uppercase letter at least");

                }
                if (!password.Any(char.IsLower))  //if there is no lower case letter
                {
                    throw new Exception("password should have one lower letter at least");

                }
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //checking whether password contains a digit or not
        public static Boolean IsDigitPresent(String password)
        {
            try
            {
                if (!password.Any(char.IsDigit))
                {
                    throw new Exception("passwor should have one digit at least");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }


        }

        public static Boolean IsPasswordValid(String password)
        {
            Boolean passLength = PasswordLength(password);
            Boolean upperAndLowerPresent = IsUpperAndLowerCasePresent(password);
            Boolean digitPresent = IsDigitPresent(password);
            if (passLength && upperAndLowerPresent && digitPresent)    //if all the conditions are true
            {
                //Console.WriteLine("Valid");
                //Console.ReadLine();
                return true;
            }
            else                                                       //else
            {
                //Console.WriteLine("Invalid");
                //Console.ReadLine();
                return false;
            }
        }
       
    }
}
