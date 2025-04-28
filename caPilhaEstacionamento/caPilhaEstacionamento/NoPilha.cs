using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaEstacionamento
{
    internal class NoPilha
    {
        // atributos
        private Carro info;
        private NoPilha next;

        // métodos
        public NoPilha(Carro c)
        {
            info = c;
            next = null;
        }

        internal Carro Info { get => info; set => info = value; }
        internal NoPilha Next { get => next; set => next = value; }
    } // fim da classe NoPilha
}
