using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPihaChar
{
    internal class Pilha
    {
        // atributos
        char[] arrayPilha = new char[20];
        int topo;


        // métodos
        public Pilha()
        {
            topo = -1;
        }

        public bool estaVazia()
        {
            if (topo == -1)
                return true;
            else
                return false;
        }

        public void insere(char n) // push
        {
            topo++;
            arrayPilha[topo] = n;
        }

        public void imprime()
        {
            int temp = topo;
            while (temp != -1)
            {
                Console.WriteLine(arrayPilha[temp]);
                temp--;
            }
        }

        public char remove() // pop
        {
            char temp = arrayPilha[topo];
            topo--;
            return temp;

        }
    }
}
