using System;

namespace ConsoleApp
{
    class Servico
    {
        
        public int codigo { get; set; }
        public Fisico fisico { get; set; }
        //public Juridico juridico { get; set; }
        public Peca peca { get; set; }
        public string status { get; set; }
        public string numSerie { get; set; }
        public Impressora produto { get; set; }
        public string defeito { get; set; }
        public string laudo { get; set; }

        public dynamic tipoMetodo(ETipoMetodo tipo)
        {
            if (tipo == ETipoMetodo.Incluir)
                return incluir();
            else if (tipo == ETipoMetodo.Consultar)
                return consultar();
            else if (tipo == ETipoMetodo.MudarStatus)
                return mudarStatus();
            else
                return relatorio();
        }

        public string incluir()
        {
            return "Método INCLUIR da classe Serviço";
        }

        public Servico IncluirServico(Servico servico)
        {
            Random rdn = new Random();
            codigo = rdn.Next(0, 2000);
            defeito = servico.defeito;
            numSerie = servico.numSerie;

            return (this);
        }
        public string consultar()
        {
            return "Método CONSULTAR da classe Serviço";
        }
        public string mudarStatus()
        {
            return "Método mudarSTATUS da classe Serviço";
        }
        public string relatorio()
        {
            return "Método RELATÓRIO da classe Serviço";
        }
    }
}
