using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 28;

            int sum = 0;

            for (int i = A; i <= B; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма всех чисел = {sum}");
            Console.WriteLine("Нечетные числа:");

            for(int i = A; i <= B; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
