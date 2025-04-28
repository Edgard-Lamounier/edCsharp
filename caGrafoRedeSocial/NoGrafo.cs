using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoRedeSocial
{
    internal class NoGrafo
    {
        NoGrafo previo;
        Pessoa  data;
        Lista   listaAmigos;
        NoGrafo next;

        public NoGrafo(Pessoa pessoa)
        {
            previo = null;
            data = pessoa;
            listaAmigos = new Lista();
            next = null;
        }

        // getters & setters
        internal NoGrafo Previo { get => previo; set => previo = value; }
        internal Pessoa Data { get => data; set => data = value; }
        internal Lista ListaAmigos { get => listaAmigos; set => listaAmigos = value; }
        internal NoGrafo Next { get => next; set => next = value; }
    
    } // fim da classe NoGrafo
}
