using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revisao
{
    public class Program
    {
        static void Main(string[] arg)
        {
            //Console.WriteLine("AAAAAAAAAAAAAAAAAAA");

            string opcUser = ObterOpc();

            while (opcUser.ToUpper() != "X")
            {
                switch (opcUser)
                {
                    case "1":
                        Console.WriteLine("opc1");
                        break;
                    case "2":
                        Console.WriteLine("opc2");
                        break;
                    case "3":
                        Console.WriteLine("opc3");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Você deve inserir opcs válidas");
                }

                opcUser = ObterOpc();

            }

            

        }

        private static string ObterOpc()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opc desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("x- Sair");
            Console.WriteLine();

            string opcUser = Console.ReadLine();
            return opcUser;
        }
    }
}