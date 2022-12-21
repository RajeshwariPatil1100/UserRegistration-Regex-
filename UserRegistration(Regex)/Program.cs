using System;
using System.Text.RegularExpressions;//namespace for regex
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserRegistration_Regex_ 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("User Registration Problem using REGEX");
                Console.WriteLine("1.First Name\n2.Last Nmae\n");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FirstName uc1 = new FirstName();
                        uc1.First();
                        break;
                    case 2:
                        LastName uc2 = new LastName();
                        uc2.Last();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }

    }
}