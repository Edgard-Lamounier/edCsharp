using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoRedeSocial
{
    internal class NoLista
    {
        private NoLista previo;
        private Pessoa data;
        private NoLista next;

        public NoLista(Pessoa p)
        {
            previo = null;
            data = p;
            next = null;
        }


        // getters & setters
        internal NoLista Previo { get => previo; set => previo = value; }
        internal Pessoa Data { get => data; set => data = value; }
        internal NoLista Next { get => next; set => next = value; }
    }
}
