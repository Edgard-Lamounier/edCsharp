using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRedeSocialGrafo
{
    internal class NoGrafo
    {
        // atributos
        private NoGrafo     previo;
        private Pessoa      pessoa;
        private Lista       listaAmigos;
        private NoGrafo     next;

        // métodos
        public NoGrafo(Pessoa _pessoa)
        {
            previo = null;
            pessoa = _pessoa;
            listaAmigos = new Lista();
            next = null;
        }

        // getters & setters
        internal NoGrafo Previo { get => previo; set => previo = value; }
        internal Pessoa Pessoa { get => pessoa; set => pessoa = value; }
        internal Lista ListaAmigos { get => listaAmigos; set => listaAmigos = value; }
        internal NoGrafo Next { get => next; set => next = value; }
    } // fim da classe NoGrafo
}
