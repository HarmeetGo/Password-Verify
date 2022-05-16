
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String pass;
            pass = Console.ReadLine();

            int a = 0;
            int b = 0;
            Boolean c = true;
            Boolean num = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 65 && pass[i] <= 90)
                {
                    a++;
                }
                if (pass[i] >= 97 && pass[i] <= 122)
                {
                    b++;
                }
                if (char.IsDigit(pass[i]))
                {
                    num = true;
                }
            }
            if (pass.Length < 8)
            {
                Console.WriteLine("password should be larger than 8 chars");
                c = false;
            }
            if (a < 1)
            {
                Console.WriteLine("password should have one uppercase letter at least");
                c = false;
            }
            if (b < 1)
            {
                Console.WriteLine("password should have one lower letter at least");
                c = false;
            }
            if (num == false)
            {
                Console.WriteLine("password should have one number at least");
                c = false;
            }
            if (c == false)
            {
                Console.WriteLine("Invalid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
        }
    }
}
