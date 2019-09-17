using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhomenu
{
    class Cadastros
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int ID { get; set; }


    public Cadastros (string nome, string apelido, int id)
    {
        Nome = nome;
        Apelido = apelido;
        ID = id;
    }

    }

}