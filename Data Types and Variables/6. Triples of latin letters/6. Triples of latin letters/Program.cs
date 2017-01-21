using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                char letter = (char)('a' + i);
                for (int f = 0; f < num; f++)
                {
                    char secondLetter = (char)('a' + f);
                    for (int h = 0; h < num; h++)
                    {
                        char thirdLetter = (char)('a' + h);
                        Console.WriteLine("{0}{1}{2}", letter, secondLetter, thirdLetter);
                    }
                }
            }
        }
    }
}
