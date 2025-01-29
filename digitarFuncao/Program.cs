using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncao;
            bool digitado = false;

            Console.Write("Digite o nome da função (administrador, gerente ou usuario): ");

            do
            {
                nomeFuncao = Console.ReadLine().Trim().ToLower();

                if (nomeFuncao.Contains("administrador"))
                {
                    digitado = true;
                }
                else if (nomeFuncao.Contains("gerente"))
                {
                    digitado = true;
                }
                else if (nomeFuncao.Contains("usuario"))
                {
                    digitado = true;
                }
                else
                {
                    Console.Write($"Você digitou ({nomeFuncao}), função não reconhecida, digite outra (administrador, gerente ou usuario: ");
                }
            }
            while (digitado == false);

            Console.WriteLine($"Função {nomeFuncao} reconhecida.");
        }
    }
}
