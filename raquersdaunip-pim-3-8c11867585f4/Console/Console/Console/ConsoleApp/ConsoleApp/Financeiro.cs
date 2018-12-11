namespace ConsoleApp
{
    public class Financeiro
    {
        public float valor { get; set; }
        public string tipo { get; set; }

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
            return "Método INCLUIR da classe Financeiro";
        }
        public string consultar()
        {
            return "Método CONSULTAR da classe Financeiro";
        }
        public string alterar()
        {
            return "Método ALTERAR da classe Financeiro";
        }
        public string relatorio()
        {
            return "Método RELATÓRIO da classe Financeiro";
        }
    }
}
