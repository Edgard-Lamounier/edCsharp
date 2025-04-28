using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    internal class Fila
    {
        private NohFila INICIO;
        private NohFila FIM;

        public Fila()
        {
            INICIO = null;
            FIM = null;
        }

        internal NohFila INICIO1 { get => INICIO; set => INICIO = value; }
        internal NohFila FIM1 { get => FIM; set => FIM = value; }

        public bool estaVazia()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void insere(int n)
        {
            NohFila novoNoh = new NohFila(n);
            if(estaVazia()) // primeiro elemento da Fila
            {
                INICIO = novoNoh; 
                FIM = novoNoh;
            }
            else
            {
                FIM.Proximo = novoNoh;
                FIM = novoNoh;
            }
        } // fim do método insere

        public void imprime()
        {
            if (estaVazia())
                Console.WriteLine("Fila Vazia");
            else 
            { 
                NohFila temp = INICIO;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data + " ");
                    temp = temp.Proximo;
                }
            }
        }

        public int remove()
        {
            int temp = INICIO.Data;
            INICIO = INICIO.Proximo;
            return temp;
        }

        public int getMaior()
        {
            NohFila temp = INICIO;
            int maior = 0;

            while (temp != null)
            {
                if(temp.Data > maior)
                    maior = temp.Data;
                temp = temp.Proximo;
            }

            return maior;
        }

        public int getQtePares()
        {
            int contPares = 0;
            NohFila temp = INICIO;
            while(temp != null)
            {
                if(temp.Data % 2 == 0) // % --> retorna o resto da divisão
                    contPares++;
                temp = temp.Proximo;
            }

            return contPares;
        }
    } // fim da classe Fila
}
