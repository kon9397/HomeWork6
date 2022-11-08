using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямоугольник:\n");

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nПрямоугольный треугольник:\n");

            string rightTriangle = "";
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    rightTriangle += "*";
                }
                rightTriangle += "\n";
            }

            Console.WriteLine(rightTriangle);

            Console.WriteLine("Прямой треугольник: ");

            string triangle = "";

            for(int i = 0; i <= 5; i++)
            {
                for(int j = i; j < 5; j++)
                {
                    triangle += ' ';
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    triangle += '*';
                }
                triangle += '\n';
            }

            Console.WriteLine(triangle);

            Console.WriteLine("Ромб: ");

            int n = 6;
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++) {
                    if (Math.Abs(i) + Math.Abs(j) <= n)
                        Console.Write("*");
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
