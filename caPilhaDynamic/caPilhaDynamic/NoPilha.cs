using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDynamic
{
    internal class NoPilha
    {
        // atributos
        private int info;
        private NoPilha proximo;

        // métodos
        public NoPilha()
        {
            proximo = null;
        }

        public NoPilha(int n)
        {
            info = n;
            proximo = null;
        }

        public int Info { get => info; set => info = value; }
        internal NoPilha Proximo { get => proximo; set => proximo = value; }

    } // fim da classe NoPilha
}
