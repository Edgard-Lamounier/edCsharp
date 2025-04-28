using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRedeSocialGrafo
{
    internal class Pessoa
    {
        // atributos 
        private string nome;
        private int id;

        // métodos 
        public Pessoa(string _nome, int _id)
        {
            this.nome = _nome;
            this.id = _id;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
    } // fim da classe Pessoa
}
