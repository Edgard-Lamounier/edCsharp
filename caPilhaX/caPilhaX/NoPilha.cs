using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaX
{
    internal class NoPilha
    {
        // atributos
        private int info;
        private NoPilha next;

        // métodos
        public NoPilha(int _info)
        {
            info = _info;
            next = null;
        }

        public int Info { get => info; set => info = value; }
        internal NoPilha Next { get => next; set => next = value; }


    }
}
