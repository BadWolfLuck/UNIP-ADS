using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim.Models
{
    class PessoaJuridica: Pessoa
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
    }
}
