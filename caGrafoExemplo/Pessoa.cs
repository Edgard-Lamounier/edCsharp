using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoExemplo
{
    internal class Pessoa
    {
        private string nome;
        private int  id;
        

        public Pessoa(string _nome, int _id) 
        { 
            this.nome = _nome;
            this.id = _id;
            
        }

        // getters & setters
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        
        

    }
}
