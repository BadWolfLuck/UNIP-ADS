using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim.Models
{
    class Peca
    {
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public int ID_Peca { get; set; }
        public int Quantidade { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
