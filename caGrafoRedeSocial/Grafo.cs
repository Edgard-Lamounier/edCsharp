using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoRedeSocial
{
    // o Grafo será representado como uma lista de NoGrafo
    internal class Grafo
    {
        NoGrafo INICIO;
        NoGrafo FIM; 

        public Grafo()
        {
            INICIO = null;
            FIM = null;
        }

        public bool estaVazio()
        {
            if (INICIO == null && FIM == null)
                return true;
            else
                return false;
        }

        public void insereFim(Pessoa p)
        {
            NoGrafo newNoh = new NoGrafo(p);

            if (estaVazio())
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

        public void adicionaAresta(Pessoa p1, Pessoa p2) 
        {
            NoGrafo noPessoa1 = achaNo(p1);
            NoGrafo noPessoa2 = achaNo(p2);

            noPessoa1.ListaAmigos.insereFim(p2);
            noPessoa2.ListaAmigos.insereFim(p1);

        }

        public NoGrafo achaNo(Pessoa p)
        {
            NoGrafo foundNoh = INICIO;
            while (foundNoh != null) // percorre a lista a partir do INICIO 
            {
                if (foundNoh.Data == p)
                    return (foundNoh);
                else
                    foundNoh = foundNoh.Next;
            }
            return null;
        }

        public NoGrafo achaNoPeloNome(string nome)
        {
            NoGrafo foundNoh = INICIO;
            while (foundNoh != null) // percorre a lista a partir do INICIO 
            {
                if (foundNoh.Data.Nome == nome)
                    return (foundNoh);
                else
                    foundNoh = foundNoh.Next;
            }
            return null;
        }

        public void imprimeListaAmigos(string nome)
        {
            NoGrafo noNome = achaNoPeloNome(nome);

            if (noNome != null)
                noNome.ListaAmigos.imprimeEsqDireita();
        }
    }
}
