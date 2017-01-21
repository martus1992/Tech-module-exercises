using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           
            decimal numSum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                numSum += num;
            }
            Console.WriteLine(numSum);
        }
    }
}
