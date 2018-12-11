using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21_08
{
    class PessoaFisica
    {
        public int cpf { get; set; }
        public Pessoa pe;

        public PessoaFisica(){
        pe = new Pessoa();
    }
    }
}
