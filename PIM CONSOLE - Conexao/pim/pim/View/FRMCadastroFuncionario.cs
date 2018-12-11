using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pim.Models;
using pim.Control;

namespace pim.View
{
    public partial class FRMCadastroFuncionario : Form
    {
        public FRMCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Salvar (Pessoa pessoa)
        {
            CTR_Pessoa cTR_Pessoa = new CTR_Pessoa();
            pessoa.Nome = txtCadastroFuncionarioNome.Text;
            pessoa.Ativo = ckbCadastroFuncionarioAtivo.Checked;
            pessoa.Email = txtCadastroFuncionarioEmail.Text;
        }

        private void Salvar(Endereco endereco)
        {
            CTR_Endereco cTR_Endereco = new CTR_Endereco();
            endereco.Bairro = txtCadastroFuncionarioBairro.Text;
            endereco.CEP = txtCadastroFuncionarioCEP.Text;
            endereco.Numero = txtCadastroFuncionarioNumero.Text;
            endereco.Rua = txtCadastroFuncionarioRua.Text;
            endereco.Telefone = txtCadastroFuncionarioTelefones.Text;
        }

        private void Salvar (Funcionario funcionario)
        {
            CTR_Funcionario cTR_Funcionario = new CTR_Funcionario();
            /*funcionario.Cargo = txtCadastroFuncionarioCargo.Text;
            funcionario.Salario = txtCadastroFuncionarioSalario;*/
        }

        private void btnCadastroFuncionarioCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa();
            P.Nome = txtCadastroFuncionarioNome.Text;
            P.Ativo = ckbCadastroFuncionarioAtivo.Checked;
            P.Email = txtCadastroFuncionarioEmail.Text;
            CTR_Pessoa cTR_Pessoa = new CTR_Pessoa();
            cTR_Pessoa.Incluir(P);

            Endereco E = new Endereco();
            E.Bairro = txtCadastroFuncionarioBairro.Text;
            E.CEP = txtCadastroFuncionarioCEP.Text;
            E.Numero = txtCadastroFuncionarioNumero.Text;
            E.Rua = txtCadastroFuncionarioRua.Text;
            E.Telefone = txtCadastroFuncionarioTelefones.Text;
            CTR_Endereco cTR_Endereco = new CTR_Endereco();
            cTR_Endereco.Incluir(E);

            Funcionario F = new Funcionario();
            F.Cargo = txtCadastroFuncionarioCargo.Text;
            //F.Salario = txtCadastroFuncionarioSalario.Text;
            CTR_Funcionario cTR_Funcionario = new CTR_Funcionario();
            cTR_Funcionario.Incluir(F);
        }
    }
}
