using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    internal class NoPilha
    {
        // atributos
        public int     info;
        public NoPilha next;

        // métodos
        public NoPilha()
        { }

        public NoPilha( int _info ) // ARIDADE 1
        {
            info = _info;
            next = null;
        }

    } // fim da classe NoPilha
}
