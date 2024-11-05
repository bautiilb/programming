using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            int aux = 0;
            Console.WriteLine("Ingrese 3 numeros para comparar");
            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in nums)
            {
                if (aux < i)
                {
                    aux = i;
                }
            }
            Console.Write($"El numero mayor es: {aux}");
            Console.ReadKey();
        }
    }
}
