using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ConversionDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de grados celcius");
            double celcius = double.Parse(Console.ReadLine());
            Console.Write($"En grados Fahrenheit esto seria: °{celcius * 9/5 + 32}");
            Console.ReadKey();
        }
    }
}
