using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaX
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

        internal NoPilha Topo { get => topo; set => topo = value; }

        public bool estaVazia()
        {
            if (topo == null)
                return true;
            else return false;
        }

        public void push(int n)
        {
            NoPilha novoNo = new NoPilha(n);
            if(estaVazia())
            {
                topo = novoNo;
            }
            else
            {
                novoNo.Next = topo;
                topo = novoNo;
            }
        }

        public void imprime()
        {
            if(estaVazia())
            {
                Console.WriteLine("Pilha Vazia!");
            }
            else
            {
                NoPilha temp = topo;
                while(temp != null)
                {
                    Console.WriteLine(temp.Info);
                    temp = temp.Next;
                }
            }
        }

        public int pop() // método para desempilhar
        {
            if(estaVazia())
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                int temp = topo.Info;
                topo = topo.Next; // re-encadeamento
                return temp;
            }
        }
    }
}
