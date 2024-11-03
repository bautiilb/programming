using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 1 numero para saber si es Par o Impar:");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
                Console.Write($"El numero es Par");
            else
                Console.Write($"El numero es Impar");
            Console.ReadKey();
        }
    }
}
