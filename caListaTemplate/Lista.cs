using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaTemplate
{
    internal class Lista<TAD> : Object
    {
        protected NoLista<TAD> INICIO;
        protected NoLista<TAD> FIM;

        public Lista()
            {
              INICIO = null;
              FIM = null;
            }
    }
}
