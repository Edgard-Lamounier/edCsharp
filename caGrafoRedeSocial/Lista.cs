using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoRedeSocial
{
    internal class Lista
    {
        private NoLista INICIO;
        private NoLista FIM;

        public Lista() // construtor default
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

        public void insereInicio(Pessoa p)
        {
            NoLista newNoh = new NoLista(p);

            if (estaVazia()) // newNoh é o primeiro elemento da Lista
            {
                INICIO = newNoh;
                FIM = newNoh;
            }

            else
            {
                INICIO.Previo = newNoh;
                newNoh.Next = INICIO;
                INICIO = newNoh;
            }
        } // fim do metodo insereInicio()

        public void insereFim(Pessoa p)
        {
            NoLista newNoh = new NoLista(p);

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
            if (estaVazia())
                Console.WriteLine("Lista Vazia");
            else
            {
                NoLista temp = INICIO;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.Data.Nome + " ");
                    temp = temp.Next;
                }

            } // fim do else 

        } // fim do metodo imprimeEsqDireita()







    } // fim da classe Lista
}
