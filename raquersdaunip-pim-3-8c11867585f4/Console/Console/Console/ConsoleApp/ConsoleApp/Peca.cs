namespace ConsoleApp
{
    public class Peca
    {
        public string descricao { get; set; }
        //public Fornecedor fornecedor { get; set; }
        public float valorCompra { get; set; }
        public float valorVenda { get; set; }
        public string codPeca { get; set; }
        public int quantidade { get; set; }

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
            return "Método INCLUIR da classe Peça";
        }
        public string alterar()
        {
            return "Método ALTERAR da classe Peça";
        }
        public string consultar()
        {
            return "Método CONSULTAR da classe Peça";
        }
        public string relatorio()
        {
            return "Método RELATÓRIO da classe Peça";
        }
    }
}
