﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greating
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}. You are {2} years old." , a , b, c);
        }
    }
}
