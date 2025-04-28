using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDynamic
{
    internal class Pilha
    {
        // atributos
        private NoPilha topo;

        // métodos
        public Pilha() 
        {
            topo = null;
        }

        public bool estaVazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void insere(int n) // push()
        {
            NoPilha novoNo = new NoPilha(n);
            if(estaVazia())
                topo = novoNo;
            else
            {
                novoNo.Proximo = topo;
                topo = novoNo;
            }

        }

        public void imprime()
        {
            NoPilha temp = topo;
            while (temp != null)
            {
                Console.WriteLine(temp.Info);
                temp = temp.Proximo;
            }
        }

        public int remove() // pop()
        {
            int temp = topo.Info;
            topo = topo.Proximo;
            return temp;
        }


    } // fim da classe Pilha 
}
