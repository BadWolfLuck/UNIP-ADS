using System.Windows.Forms;

namespace ConsoleApp
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public bool Ativo { get; set; }
        public bool Fidelidade { get; set; }
        public double Real { get; set; }

        public dynamic tipoMetodo(ETipoMetodo tipo)
        {
            if (tipo == ETipoMetodo.Incluir)
                return incluir();
            else if (tipo == ETipoMetodo.Consultar)
                return consultar();
            else if (tipo == ETipoMetodo.desativarAtivar)
                return desativarAtivar();
            else
                return relatorio();
        }

        public string incluir()
        {
            return "Método INCLUIR da classe Cliente";
        }
        public virtual string consultar()
        {
            return "Método CONSULTAR da classe Cliente";
        }
        public string desativarAtivar()
        {
            return "Método desativarATIVAR da classe Cliente";
        }
        public string relatorio()
        {
            return "Método RELATÓRIO da classe Cliente";
        }
    }
}
