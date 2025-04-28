using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaEstacionamento
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Carro c1 = new Carro("BRA2E19");
            Carro c2 = new Carro("OTM2X22");
            Carro c3 = new Carro("LSN4I49");
            Carro c4 = new Carro("RIO2A18");

            Pilha  pilhaEstacionamento = new Pilha(); 
            

            pilhaEstacionamento.push(c1);
            pilhaEstacionamento.push(c2);
            pilhaEstacionamento.push(c3);
            pilhaEstacionamento.push(c4);

            pilhaEstacionamento.imprime();

            Console.ReadLine();

            pilhaEstacionamento.retiraCarro(c2);

            pilhaEstacionamento.imprime();

            Console.ReadLine();

        } // fim do void Main
    }
}
