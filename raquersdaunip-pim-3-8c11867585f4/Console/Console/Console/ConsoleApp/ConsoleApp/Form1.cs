using System;
using System.Windows.Forms;

namespace ConsoleApp
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        string retorno;
        Funcionario objFunc = new Funcionario();
        Cliente objCliente = new Cliente();
        Peca objPeca = new Peca();
        Financeiro objFinanceiro = new Financeiro();
        Servico objServico = new Servico();
        Fisico objFisico = new Fisico();

        private void button1_Click(object sender, EventArgs e)
        {
            retorno = objFunc.tipoMetodo(ETipoMetodo.Consultar);

            MessageBox.Show(retorno);
        }

        private void btnFuncionarioIncluir_Click(object sender, EventArgs e)
        {
            retorno = objFunc.tipoMetodo(ETipoMetodo.Incluir);

            MessageBox.Show(retorno);
        }

        private void btnFuncionarioAlterar_Click(object sender, EventArgs e)
        {
            retorno = objFunc.tipoMetodo(ETipoMetodo.Alterar);

            MessageBox.Show(retorno);
        }

        private void btnFuncionarioRelatorio_Click(object sender, EventArgs e)
        {
            retorno = objFunc.tipoMetodo(ETipoMetodo.Relatorio);

            MessageBox.Show(retorno);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retorno = objCliente.tipoMetodo(ETipoMetodo.Incluir);

            MessageBox.Show(retorno);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja consultar com sobreposição de método?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                retorno = objFisico.tipoMetodo(ETipoMetodo.Consultar);
            }
            else
            {
                retorno = objCliente.tipoMetodo(ETipoMetodo.Consultar);
            }

            MessageBox.Show(retorno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retorno = objCliente.tipoMetodo(ETipoMetodo.desativarAtivar);

            MessageBox.Show(retorno);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            retorno = objCliente.tipoMetodo(ETipoMetodo.Relatorio);

            MessageBox.Show(retorno);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            retorno = objPeca.tipoMetodo(ETipoMetodo.Incluir);

            MessageBox.Show(retorno);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            retorno = objPeca.tipoMetodo(ETipoMetodo.Consultar);

            MessageBox.Show(retorno);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            retorno = objPeca.tipoMetodo(ETipoMetodo.Alterar);

            MessageBox.Show(retorno);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            retorno = objPeca.tipoMetodo(ETipoMetodo.Relatorio);

            MessageBox.Show(retorno);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            retorno = objFinanceiro.tipoMetodo(ETipoMetodo.Incluir);

            MessageBox.Show(retorno);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            retorno = objFinanceiro.tipoMetodo(ETipoMetodo.Consultar);

            MessageBox.Show(retorno);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            retorno = objFinanceiro.tipoMetodo(ETipoMetodo.Alterar);

            MessageBox.Show(retorno);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            retorno = objFinanceiro.tipoMetodo(ETipoMetodo.Relatorio);

            MessageBox.Show(retorno);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            retorno = objServico.tipoMetodo(ETipoMetodo.Incluir);

            MessageBox.Show(retorno);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            retorno = objServico.tipoMetodo(ETipoMetodo.Consultar);

            MessageBox.Show(retorno);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            retorno = objServico.tipoMetodo(ETipoMetodo.MudarStatus);

            MessageBox.Show(retorno);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            retorno = objServico.tipoMetodo(ETipoMetodo.Relatorio);

            MessageBox.Show(retorno);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            objServico.defeito = txtDefeito.Text;
            objServico.numSerie = txtNumSerie.Text;

            Servico ServicoGerado = objServico.IncluirServico(objServico);

            txtDefeito.Text = "";
            txtNumSerie.Text = "";

            if (ServicoGerado == null)
                MessageBox.Show("Serviço inválido");
            else
            {
                MessageBox.Show("Serviço incluído com sucesso");

                txtResult.Text = "Código do Serviço: " + ServicoGerado.codigo + Environment.NewLine + 
                    "Defeito: " + ServicoGerado.defeito + Environment.NewLine + 
                    "Número de Série: " + ServicoGerado.numSerie;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDefeito.Text = String.Empty;
            txtNumSerie.Text = String.Empty;
        }
    }
}
