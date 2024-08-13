using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;

            Console.Write("Entre seu nome");//Leia teclado, Write(Escreva) Exibe o valor guardado
            NOME = Console.ReadLine();//Lê a proxima linha
            Console.Write("Ola, " + NOME);//Guarda o valor das string então exibe o valor guardado em nome   
            Console.WriteLine("");//Pula-linha
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
