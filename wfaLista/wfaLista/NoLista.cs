using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaLista
{
    internal class NoLista
    {
        // atributos
        private NoLista     previo;
        private int         info;
        private NoLista     prox;

        // métodos
        public NoLista()
        {
            previo = null;
            info = 0;
            prox = null;
        }
        
       public NoLista(int _info)
        {
            previo = null;
            info = _info;
            prox = null;
        }
        
        
        // getters & setters
        public int Info { get => info; set => info = value; }
        internal NoLista Previo { get => previo; set => previo = value; }
        internal NoLista Prox { get => prox; set => prox = value; }

        
    } // fim da classe NoLista
}
