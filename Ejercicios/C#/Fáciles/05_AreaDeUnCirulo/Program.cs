using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_AreaDeUnCirulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio de un circulo");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine($"El area del circulo es: {Math.Pow(radio, 2) * Math.PI}");
            Console.ReadKey();
        }
    }
}
