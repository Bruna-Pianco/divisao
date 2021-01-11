using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisao
{
    class Program

    {
        static void Main(string[] args)
        {
            double x, y;
            {
                Console.WriteLine("Informe 2 números para realizar a divisão, será realizada do primeiro número pelo segundo número!:\n");
                Console.WriteLine("Informe o primeiro número para realizar a divisão:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o número divisor:");
                y = double.Parse(Console.ReadLine());

                if (y == 0)
                {
                    Console.WriteLine("Divisão impossivel, escolha outro número divisor!");
                }

                else
                {
                    Console.WriteLine("O Resultado da divisão é " + x / y);
                }
                Console.ReadKey();



            }
        }

    }
}

