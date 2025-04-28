using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    internal class NohFila
    {
        private int data;
        private NohFila proximo; 


        public NohFila( ) { }

        public NohFila( int _data )
        {
            data = _data;
            proximo = null;
        }

        public NohFila(int _data, NohFila _proximo)
        {
            data = _data;
            proximo = _proximo;
        }

        public int Data { get => data; set => data = value; }
        internal NohFila Proximo { get => proximo; set => proximo = value; }

    } // fim da classe NohFila
}
