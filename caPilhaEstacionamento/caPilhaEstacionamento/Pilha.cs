using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaEstacionamento
{
    internal class Pilha
    {
        // atributos 
        private NoPilha topo;
        private int qteCarros;

        // métodos
        public Pilha()
        {
            qteCarros = 0;
            topo = null;
        }

        internal NoPilha Topo { get => topo; set => topo = value; }
        public int QteCarros { get => qteCarros; set => qteCarros = value; }

        public bool estaVazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
                return false;
        }

        public void push(Carro n) // insere na Pilha
        {
            if (qteCarros == 10)
            {
                Console.WriteLine("Estacionamento Lotado!");
            }
            else
            {
                NoPilha novoNo = new NoPilha(n);
                if (estaVazia())
                {
                    topo = novoNo;
                }
                else
                {
                    novoNo.Next = topo;
                    topo = novoNo;
                }
             qteCarros++;
            }
        }

        public void imprime()
        {
            if (estaVazia())
            {
                Console.WriteLine("Pilha Vazia!");
            }
            else
            {
                NoPilha temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.Info.Placa);
                    temp = temp.Next;
                }
            }
        }

        public Carro pop()
        {
            if (estaVazia())
            {
                Console.WriteLine("Estacionamento Vazio");
                return null;
            }
            else
            {
                Carro temp = topo.Info;
                topo = topo.Next;
                qteCarros--;
                return temp;
            }
        }

        public bool encontraCarro(Carro carro)
        {
            NoPilha temp = topo;

            while (temp != null)
            {
                if (carro.Placa == temp.Info.Placa)
                { 
                    return true; 
                }
                temp = temp.Next;
            }
            return false;   
        }

        public void retiraCarro(Carro c)
        {
            if (encontraCarro(c) == true)
            {
                Pilha p2Auxiliar = new Pilha();
                NoPilha temp = Topo;
                while (temp != null)
                {
                    if (temp.Info.Placa == c.Placa)
                    {
                        // faz o pop do carro
                        Console.WriteLine("Retirando o carro de placa " + temp.Info.Placa);
                        // empilha na p1Estacionamento a partir da p2Auxiliar
                        this.pop();
                        while (p2Auxiliar.Topo != null)
                        {
                            this.push(p2Auxiliar.pop());
                        }
                        break;
                    }
                    else
                    {
                        // faz o pop do carro e push na p2Auxiliar
                        p2Auxiliar.push(this.pop());
                        temp = temp.Next;
                    }
                }
            }
            else
            {
                Console.WriteLine("O carro solicitado não está estacionado");
            }
        }

    } // fim da classe Pilha
}
