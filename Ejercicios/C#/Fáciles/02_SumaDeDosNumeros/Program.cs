using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SumaDeDosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 2 numeros para sumar:");
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            Console.Write($"La suma de los numeros es: {num + num1}");
            Console.ReadKey();
        }
    }
}
