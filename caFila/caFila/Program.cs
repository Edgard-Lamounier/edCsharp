using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila f = new Fila();

            f.insere(5);
            f.insere(2);
            f.insere(10);
            f.insere(3);
            f.insere(20);
            f.insere(30);
            f.insere(25);

            f.imprime();

            

            // Console.WriteLine("Removendo o  " + f.remove());

            // f.imprime();

            Console.ReadLine();

            Console.WriteLine("O maior elemento da Fila é: " + f.getMaior());
            // Console.WriteLine("O menor elemento da Fila é: " + f.getMenor());
            Console.WriteLine("A qte de números pares da Fila é: " + f.getQtePares());
            // Console.WriteLine("A qte de números impares da Fila é: " + f.getQteImpares());
            Console.ReadLine();
        }
    }
}
