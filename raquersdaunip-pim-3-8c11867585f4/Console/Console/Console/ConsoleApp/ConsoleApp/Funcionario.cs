using System.Windows.Forms;

namespace ConsoleApp
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public float salario { get; set; }
        public string cargo { get; set; }

        public dynamic tipoMetodo(ETipoMetodo tipo)
        {
            if (tipo == ETipoMetodo.Incluir)
                return incluir();
            else if (tipo == ETipoMetodo.Consultar)
                return consultar();
            else if (tipo == ETipoMetodo.Alterar)
                return alterar();
            else
                return relatorio();
        }

        public string incluir()
        {
            return "Método INCLUIR da classe Funcionário";
        }
        public string consultar()
        {
            return "Método CONSULTAR da classe Funcionário";
        }
        public string alterar()
        {
            return "Método ALTERAR da classe Funcionário";
        }
        public string relatorio()
        {
            return "Método RELATÓRIO da classe Funcionário";
        }
    }
}
