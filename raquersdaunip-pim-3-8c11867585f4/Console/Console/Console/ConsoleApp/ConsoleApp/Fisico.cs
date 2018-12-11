namespace ConsoleApp
{
    class Fisico : Cliente
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        public override string consultar()
        {
            return "Método CONSULTAR da classe Fisico(Herdando da classe Cliente, sobrepondo o método CONSULTAR)";
        }
    }
}
