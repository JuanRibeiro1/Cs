using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Seleciona uma das opções seguintes: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int indice = int.Parse(Console.ReadLine());

            Opcao opcaoSelecionada = (Opcao)indice;

            switch(opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Criar");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listar");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizar");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

                
            }
            */

            string[] palavras = { "Juan", "Gabriel", "Oliveira", "Ribeiro" };

            foreach(string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }
        }
    }
}
