using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p1 = new Pilha(); 
            
            int aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Inserir elemento na pilha");
                Console.WriteLine(" [2] - Remover elemento da pilha");
                Console.WriteLine(" [3] - Imprimir todos elementos da pilha");
                Console.WriteLine(" [4] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Entre o número a ser inserido = ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        p1.push(n);
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Desempilhando o ... " + p1.pop());
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        p1.imprime();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        aux = 0;
                        Console.Clear();
                        break;


                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;
                }


            }

        } // fim do void Main
    }
}
