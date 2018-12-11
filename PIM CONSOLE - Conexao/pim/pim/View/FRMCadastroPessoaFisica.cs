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
    public partial class FRMCadastroPessoaFisica : Form
    {
        private Endereco endereco;

        public FRMCadastroPessoaFisica()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
 
        

        private void Salvar (Endereco endereco)
        {
            CTR_Endereco cTR_Endereco = new CTR_Endereco();
            endereco.Bairro = txtCadastroClienteFisicoBairro.Text;
            endereco.CEP = txtCadastroClienteFisicoCEP.Text;
            endereco.Numero = txtCadastroClienteFisicoNumero.Text;
            endereco.Rua = txtCadastroClienteFisicoRua.Text;
            endereco.Telefone = txtCadastroClienteFisicoTelefones.Text;
            cTR_Endereco.Incluir(endereco);
        }

        private void Salvar (PessoaFisica pessoaFisica)
        {
            CTR_PessoaFisica cTR_PessoaFisica = new CTR_PessoaFisica();
            pessoaFisica.RG = txtCadastroClienteFisicoRG.Text;
            pessoaFisica.CPF = txtCadastroClienteFisicoCPF.Text;
            pessoaFisica.Nome = txtCadastroClienteFisicoNome.Text;
            pessoaFisica.Ativo = ckbCadastroClienteFisicoAtivo.Checked;
            pessoaFisica.Fidelidade = ckbCadastroClienteFisicoFidelidade.Checked;
            pessoaFisica.Email = txtCadastroClienteFisicoEmail.Text;
            cTR_PessoaFisica.Incluir(pessoaFisica, endereco);
            
        }

        private void btnCadastroClienteFisicoCadastrar_Click(object sender, EventArgs e)
        {
            Endereco E = new Endereco();
            Salvar(E);
            

            PessoaFisica PF = new PessoaFisica();
            Salvar(PF);

            MessageBox.Show("Cadastrado com sucesso!");


        }
    }
}
