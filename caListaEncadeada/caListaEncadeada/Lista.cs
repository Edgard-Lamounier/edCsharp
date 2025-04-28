using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaEncadeada
{
    internal class Lista
    {
        private NohLista INICIO;
        private NohLista FIM;

        public Lista()
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazia()
        {
            if(INICIO == null && FIM == null) 
                return true;
            else 
                return false;
        }

        public void insereInicio(int n)
        {
            NohLista novoNoh = new NohLista(n);
            if(estaVazia())  // novoNoh é o primeiro elemento a ser inserido
            { 
                INICIO = novoNoh;
                FIM = novoNoh;
            }
            else // a lista não está vazia
            {
                novoNoh.Proximo = INICIO;
                INICIO.Previo = novoNoh;
                INICIO = novoNoh;
            }
        }

        public void imprimeINICIO_FIM()
        {
            NohLista temp = INICIO;
            while(temp != null)
            {
                Console.WriteLine(temp.Info);
                temp = temp.Proximo;
            }
        }

        public void remove(int n) // este método considera que n está lista
        {
            NohLista noRemove = EncontraNoh(n);
 
            if (noRemove == INICIO) // n está no inicio da lista
            {
                INICIO = INICIO.Proximo;
                INICIO.Previo = null;
            }

            else if (noRemove == FIM) // n está no fim da lista
            {
                FIM = FIM.Previo;
                FIM.Proximo = null;
            }
            
            else // n está no meio da lista
            {
                (noRemove.Previo).Proximo = noRemove.Proximo;
                (noRemove.Proximo).Previo = noRemove.Previo;
            }
        }

        public NohLista EncontraNoh(int n)
        {
            NohLista temp = INICIO;

            while(temp != null)
            {
                if (temp.Info == n)
                    return temp;
                temp = temp.Proximo;
            }

            return null;
        }


        public int Maior()
        {
            int maior = -100000; // int maior = INICIO.Info()

            NohLista temp = INICIO;
            while (temp != null)
            {
                if (temp.Info > maior)
                   maior = temp.Info;

                temp = temp.Proximo;
            }
            return maior;
        }
    }
}
