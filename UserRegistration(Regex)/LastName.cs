﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Regex_
{
    internal class LastName
    {
        public void Last()
        {
            Console.WriteLine(" Enter User Last Name");
            var data = Console.ReadLine();
            string pattern = "[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))//match method call from inbuild Regex class
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It's a Valid Last Name");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It's a InValid Last Name");
                Console.ResetColor();
            }
        }
    }
}