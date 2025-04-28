using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRedeSocialGrafo
{
    internal class Lista
    {
        // atributos
        private NoLista INICIO;
        private NoLista FIM;

        public Lista() 
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void insereFim(Pessoa n)
        {
            NoLista newNoh = new NoLista(n);

            if (estaVazia())
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                FIM.Next = newNoh;
                newNoh.Previo = FIM;
                FIM = newNoh;
            }
        } // fim do metodo insereFim()

        public void imprimeEsqDireita()
        {
            NoLista temp = INICIO;
            while (temp != null)
            {
                Console.WriteLine(temp.Data.Nome + " ");
                temp = temp.Next;
            }
        }

    } // fim da classe Lista
}
