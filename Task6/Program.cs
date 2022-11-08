using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
