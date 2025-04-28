using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class Pilha
    {
        // atributos
        int[] arrayPilha = new int[10];
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

        public void insere(int n) // push
        {
            topo++;
            arrayPilha[topo] = n;
        }

        public void imprime()
        {
            int temp = topo;
            while(temp != -1)
            {
                Console.WriteLine(arrayPilha[temp]);
                temp--; 
            }
        }

        public int remove() // pop
        {
            int temp = arrayPilha[topo];
            topo--;
            return temp;
            
        }



    } // fim da classe Pilha
}
