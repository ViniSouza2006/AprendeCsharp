using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL;
            /*HT = HORA TRABALHADA   VH = VALOR DA HORA   PD = PERCENTUAL DE DESCONTO
              SB =                   TD =                 SL = SALARIO LIQUIDO       */

            Console.WriteLine("Horas trabalhadas ............: ");//WRITELINE = Escreva na linha 
            HT = float.Parse(Console.ReadLine());// FLOAT = Numeros flutuantes (". ,")
            Console.WriteLine("Valor da hora ............: ");
            VH = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor do percentual de desconto .: ");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;//SB é atribuido ao valor de HT * VH
            TD = (PD / 100) * SB;//TD é atribuido ao valor de PD / 100
            SL = SB - TD;//SL é atribuido ao valor de SB - TD


            Console.WriteLine();
            Console.WriteLine("Salario liquido ............: ");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.WriteLine("Tecla <Enter> para encerrar... ");
            Console.ReadLine();//Aguarda a finalização do programa 
        }
    }
}
