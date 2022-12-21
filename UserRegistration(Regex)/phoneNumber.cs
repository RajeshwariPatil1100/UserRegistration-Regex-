using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Regex_
{
    internal class phoneNumber
    {
        public void PhnNum()
        {
            Console.WriteLine("Enter Mobile Number");
            var data = Console.ReadLine();
            string pattern = "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";//for start^ end $
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))//match method call from inbuild Regex class
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It's a Valid Number");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It's a InValid Number");
                Console.ResetColor();
            }
        }
}
