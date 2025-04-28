using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class NoGrafo<ADT> : Object
    {
        // atributos
        private NoGrafo<ADT> previo;
        private ADT data;
        private Lista<ADT> listaAmigos;
        private NoGrafo<ADT> next;

        public NoGrafo(ADT _data)
        {
            previo = null;
            data = _data;
            listaAmigos = new Lista<ADT>();
            next = null;
        }



        // getters & setters
        public ADT Data { get => data; set => data = value; }
        internal NoGrafo<ADT> Previo { get => previo; set => previo = value; }
        internal Lista<ADT> ListaAmigos { get => listaAmigos; set => listaAmigos = value; }
        internal NoGrafo<ADT> Next { get => next; set => next = value; }
    }
}
