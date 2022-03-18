using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_media_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calcular a média aritimética simples.");
            Console.WriteLine();

            Console.Write("Digite o valor 1: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor 2: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor 3: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Valor da média  : "+(a + b + c) / 3.0f);
            

            Console.ReadLine();
        }
    }
}
