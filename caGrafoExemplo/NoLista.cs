using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class NoLista<ADT> : Object // Abstract Data Type
    {
        // atributos
        private NoLista<ADT> previo;
        private ADT data;
        private NoLista<ADT> next;

        public NoLista(ADT n)
        {
            previo = null;
            data = n;
            next = null;
        }

        // getters & setters
        public ADT Data { get => data; set => data = value; }
        internal NoLista<ADT> Previo { get => previo; set => previo = value; }
        internal NoLista<ADT> Next { get => next; set => next = value; }

    } // fim da classe NoLista
}
