using System;
using System.Collections.Generic;
using System.Text;

namespace ReadJson.Model
{
    class Pessoa
    {
        public List<Endereco> Endereco { get; set; }
        public int Idade { get; set; }
        public string Nick { get; set; }
        public string Nome { get; set; }
    }
}
