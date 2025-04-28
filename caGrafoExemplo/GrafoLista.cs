using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class GrafoLista<ADT> : Object
    {
        private NoGrafo<ADT> INICIO;
        private NoGrafo<ADT> FIM;

        public GrafoLista()
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

        public void insereFim(ADT n)
        {
            NoGrafo<ADT> newNoh = new NoGrafo<ADT>(n);

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

        public void adicionaAresta(string nome1, string nome2)
        {

        }

        public NoGrafo<ADT> encontraNoh(string nomePessoa)
        {

            // Compara<ADT> cmp = new Compara<ADT>(nomePessoa);

            ADT pessoa = INICIO.Data;
            Console.WriteLine("Type is {0}", pessoa.GetType());

            string nome = (Pessoa) pessoa.Nome;

            //NoGrafo<ADT> foundNo = INICIO;
            
            //while (foundNo != null) // percorre a lista a partir do INICIO 
            //{
            //    if (foundNo.Data.Equals(nomePessoa)) // comparação entre ADTs 
            //        return (foundNo);
            //    else
            //        foundNo = foundNo.Next;
            //}

            return null;
        } // fim do método encontraNoh

    }
}
