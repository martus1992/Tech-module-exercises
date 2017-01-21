using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse (Console.ReadLine());
            int courses = (int)Math.Ceiling(n / p);
            Console.WriteLine(courses);


        }
    }
}
