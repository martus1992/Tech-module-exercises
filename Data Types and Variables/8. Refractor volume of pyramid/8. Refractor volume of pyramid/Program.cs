using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Refractor_volume_of_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            var v = (lenght * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", v);

        }
    }
}
