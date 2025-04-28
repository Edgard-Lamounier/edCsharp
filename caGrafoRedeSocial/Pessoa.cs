using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caGrafoRedeSocial
{
    internal class Pessoa
    {
        string nome;
        int id;
 
        public Pessoa(string _nome, int _id)
        {
            nome = _nome;
            id = _id;
       }

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
    }
}
