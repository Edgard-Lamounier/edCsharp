using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaEncadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();

            l.insereInicio(10);
            l.insereInicio(20);
            l.insereInicio(30);
            l.insereInicio(40);

            l.imprimeINICIO_FIM();

            
            l.insereInicio(35);

            Console.WriteLine("Removendo o 30"); l.remove(30);

            l.imprimeINICIO_FIM();

            Console.WriteLine("O maior da lista é: " + l.Maior());

            Console.ReadLine();
        }
    }
}
