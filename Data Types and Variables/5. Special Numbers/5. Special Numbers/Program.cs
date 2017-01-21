using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
			{
			   var sum = 0;
               var digits = i;
               while (digits > 0)
               {
                   sum += digits % 10;
                   digits = digits / 10;
               }
               if (sum == 5 || sum == 7 || sum == 11)
               {
                   
                   Console.WriteLine(i + " -> " + "True");
               }
               else
               {
                   
                   Console.WriteLine(i + " -> " + "False");
               }


			}
            
        }
    }
}
