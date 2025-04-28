using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaTemplate
{
    internal class NoLista<TAD> : Object
    {
        private NoLista<TAD> previous;
        private TAD data;
        private NoLista<TAD> next;

        public NoLista(TAD _data)
        {
            previous = null;
            this.data = _data;
            next = null;
        }

        public NoLista(NoLista<TAD> _previous, TAD _data, NoLista<TAD> _next)
        {
            this.previous = _previous;
            this.data = _data;
            this.next = _next;
        }

        public TAD Data { get => data; set => data = value; }
        internal NoLista<TAD> Previous { get => previous; set => previous = value; }
        internal NoLista<TAD> Next { get => next; set => next = value; }
    }
}
