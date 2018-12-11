using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim.Models
{
    class Pessoa: Endereco
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Fidelidade { get; set; }
        public Endereco Endereco { get; set; }
    }

    
}
