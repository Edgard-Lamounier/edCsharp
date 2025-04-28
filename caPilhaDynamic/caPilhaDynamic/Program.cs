using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha();

            p.insere(4);
            p.insere(7);
            p.insere(8);

            p.imprime();

            Console.WriteLine("Desempilhando ... " + p.remove());

            p.imprime();
            Console.ReadLine();
        }
    }
}
