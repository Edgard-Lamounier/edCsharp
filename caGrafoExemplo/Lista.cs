using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class Lista<ADT> : Object
    {
        // atributos
        private NoLista<ADT> INICIO;
        private NoLista<ADT> FIM;

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

        public virtual void insereInicio(ADT n)
        {
            NoLista<ADT> newNoh = new NoLista<ADT>(n);

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

        public void insereFim(ADT n)
        {
            NoLista<ADT> newNoh = new NoLista<ADT>(n);

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

        public virtual void imprimeEsqDireita()
        {
            if (estaVazia())
                Console.WriteLine("Lista Vazia");
            else
            {
                NoLista<ADT> temp = INICIO;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }

            } // fim do else 

        } // fim do metodo imprimeEsqDireita()

        public void imprimeDirEsquerda()
        {
            if (estaVazia())
                Console.WriteLine("Lista Vazia");
            else
            {
                NoLista<ADT> temp = FIM;
                while (temp != null) // while(temp)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Previo;
                }

            } // fim do else 

        } // fim do metodo imprimeDirEsquerda()

        public void Remove(ADT n) // não trata se a lista está vazia e considera que o elemento a ser removido está na lista!
        {
            NoLista<ADT> thisPtr = encontraNoh(n); // encontra o nó onde está o elemento a ser removido

            if (thisPtr == INICIO) // remover do INICIO da lista
            {
                INICIO = INICIO.Next;
                INICIO.Previo = null;
            }

            else if (thisPtr == FIM) // remover do FIM da lista
            {
                FIM = FIM.Previo; 
                FIM.Next = null;
            }

            else // remove um elemento do MEIO da lista
            {
                (thisPtr.Previo).Next = thisPtr.Next;
                (thisPtr.Next).Previo = thisPtr.Previo;
            }

        } // fim do método Remove



        public NoLista<ADT> encontraNoh(ADT tipoEncontrado)
        {
            NoLista<ADT> foundNoh = INICIO;
            while (foundNoh != null) // percorre a lista a partir do INICIO 
            {
                if (foundNoh.Equals(tipoEncontrado)) // comparação entre ADTs 
                    return (foundNoh);
                else
                    foundNoh = foundNoh.Next;
            }
            return null;
        } // fim do método encontraNoh


    }


} // fim da classe Lista

