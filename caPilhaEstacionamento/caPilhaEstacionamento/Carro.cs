using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaEstacionamento
{
    internal class Carro
    {
        // atributos 
        private string placa;

        // métodos
        public Carro(string _placa)
        {
            this.placa = _placa;    
        }

        public string Placa { get => placa; set => placa = value; }
    } // fim da classe Carro
}
