using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов");
            int clientsNumber = Convert.ToInt32(Console.ReadLine());

            int roadsNumber = 1;
            do {
                roadsNumber *= clientsNumber;
                clientsNumber -= 1;
            }
            while (clientsNumber > 0);
            Console.WriteLine($"Количество возможных вариантов доставки: {roadsNumber}");
            Console.ReadKey();
        }
    }
}
