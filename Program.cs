using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double M;
            double km;

            Console.Write("Insira a Distancia em milhias Maritimas: ");
            M = double.Parse(Console.ReadLine());

           km = M * 0.5399;

            Console.WriteLine("A Distancia em KM é Aproximadamente {0}.", km);
        }
    }
}
