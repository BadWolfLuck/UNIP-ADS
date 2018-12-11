using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim.Models
{
    class Servico
    {
        public int ID { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public string Status { get; set; }
        public string NumSerial { get; set; }
        public string Defeito { get; set; }
        public string Laudo { get; set; }
        public Impressora Produto { get; set; }
    }
}
