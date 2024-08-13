using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.WriteLine("Entre 0 1o. valor: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o 2o. valor: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine();
            Console.WriteLine("Tecla <Enter> para continuar... ");
            Console.ReadLine();
        }
    }
}
