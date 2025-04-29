using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLista
{
    internal class Lista
    {
        // atributos
        private NoLista     INICIO;
        private NoLista     FIM;

        // métodos

        public Lista()
        {
            INICIO = null; 
            FIM = null;
        }
        
        // getters & setters
        internal NoLista INICIO1 { get => INICIO; set => INICIO = value; }
        internal NoLista FIM1 { get => FIM; set => FIM = value; }

        public bool estaVazia()
        { 
           if(INICIO == null && FIM == null) 
              return true;
           else 
              return false;
        }

        public string imprime()
        {

            string lista = "";
            NoLista temp = INICIO;

            if (estaVazia())
            {
                MessageBox.Show("A lista está vazia!");
                return lista;
            }
                
            else
            {
                
                while(temp != null)
                {
                    lista = lista + " " + Convert.ToString(temp.Info);
                    temp = temp.Prox; 
                }

                return lista;  
                
            }
        }

        public void insere(int n)
        {
            NoLista novoNo = new NoLista(n);
            
            if(estaVazia())
            {
                INICIO = novoNo;
                FIM = novoNo;
            }
            else
            {
                FIM.Prox = novoNo;
                novoNo.Previo = FIM;
                FIM = novoNo;
            }
        }

        public void remove(int n)
        {
            // encontrar a referencia na lista que está o n
            NoLista noA_Ser_Removido = achaNo(n);

            if (noA_Ser_Removido != null)
            {
                if( noA_Ser_Removido == INICIO )
                {
                    INICIO = INICIO.Prox;
                    INICIO.Previo = null;
                }
                else if( noA_Ser_Removido == FIM )
                {
                    FIM = FIM.Previo;
                    FIM.Prox = null;
                }

                else // o nó a ser removido está no meio
                {
                    (noA_Ser_Removido.Previo).Prox = noA_Ser_Removido.Prox;
                    (noA_Ser_Removido.Prox).Previo = noA_Ser_Removido.Previo;
                }
            }

            else
                Console.WriteLine("Nó não encontrado");

        }

        public NoLista achaNo(int n)
        {
            NoLista temp = INICIO;
            while(temp != null)
            {
                if (temp.Info == n)
                    return temp;
                else
                    temp = temp.Prox;
            }

            return null;
        }

    } // fim da classe Lista
}
