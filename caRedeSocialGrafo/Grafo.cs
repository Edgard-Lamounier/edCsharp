using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRedeSocialGrafo
{
    // classe usada para representar um Grafo por meio de uma Lista
    internal class Grafo
    {
        // atributos
        private NoGrafo INICIO;
        private NoGrafo FIM;

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
        } // fim do método insereFim

        public void addAresta(Pessoa p1, Pessoa p2) 
        {
            NoGrafo noP1 = achaNo(p1);
            NoGrafo noP2 = achaNo(p2);

            // associar as pessoas na listaAmigos
            noP1.ListaAmigos.insereFim(p2);
            noP2.ListaAmigos.insereFim(p1);

        } // fim do método addAresta

        public NoGrafo achaNo(Pessoa p) 
        {
            NoGrafo temp = INICIO;

            while (temp != null)
            {
                if(temp.Pessoa == p)
                    return temp;
                temp = temp.Next;
            }

            return null;
        } // fim do método achaNo

        public void imprimeListaAmigos(string nome)
        {
            NoGrafo comNome = achaNoPelaString(nome);

            comNome.ListaAmigos.imprimeEsqDireita();
        }

        public NoGrafo achaNoPelaString(string nome)
        {
            NoGrafo temp = INICIO;
            while (temp != null)
            {
                if(temp.Pessoa.Nome == nome)
                    return temp;
                temp = temp.Next;
            }

            return null;
        }

    } // fim da classe Grafo
}
