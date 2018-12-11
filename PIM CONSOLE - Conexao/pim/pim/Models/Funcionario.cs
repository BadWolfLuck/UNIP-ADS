using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim.Models
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}
