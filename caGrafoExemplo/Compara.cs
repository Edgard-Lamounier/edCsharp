using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class Compara<ADT> where ADT : IComparable
    {
        private ADT _equalValue = default(ADT);
        public Compara() { }

        public Compara(ADT adt) { _equalValue = adt; }

        public bool ehIgual(ADT value)

        {
            return (value.CompareTo(_equalValue) == 0);
        }

    } // fim da classe Compara
}
