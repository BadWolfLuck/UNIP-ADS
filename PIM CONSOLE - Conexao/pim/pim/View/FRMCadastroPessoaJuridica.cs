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
    public partial class FRMCadastroPessoaJuridica : Form
    {
        public FRMCadastroPessoaJuridica()
        {
            InitializeComponent();
        }

        private void Salvar(Pessoa pessoa)
        {
            CTR_Pessoa cTR_Pessoa = new CTR_Pessoa();
            pessoa.Nome = txtCadastroClienteJuridicoRazaoSocial.Text;
            pessoa.Ativo = ckbCadastroClienteJuridicoAtivo.Checked;
            pessoa.Fidelidade = ckbCadastroClienteJuridicoFidelidade.Checked;
            pessoa.Email = txtCadastroClienteJuridicoEmail.Text;
        }

        private void Salvar(Endereco endereco)
        {
            endereco.Bairro = txtCadastroClienteJuridicoBairro.Text;
            endereco.CEP = txtCadastroClienteJuridicoCEP.Text;
            endereco.Numero = txtCadastroClienteJuridicoNumero.Text;
            endereco.Rua = txtCadastroClienteJuridicoRua.Text;
            endereco.Telefone = txtCadastroClienteJuridicoTelefones.Text;
        }

        private void Salvar(PessoaJuridica pessoaJuridica)
        {
            pessoaJuridica.CNPJ = txtCadastroClienteJuridicoCNPJ.Text;
            pessoaJuridica.IE = txtCadastroClienteJuridicoIE.Text;
        }

        private void btnCadastroClienteJuridicoCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa();
            P.Nome = txtCadastroClienteJuridicoRazaoSocial.Text;
            P.Ativo = ckbCadastroClienteJuridicoAtivo.Checked;
            P.Fidelidade = ckbCadastroClienteJuridicoFidelidade.Checked;
            P.Email = txtCadastroClienteJuridicoEmail.Text;
            CTR_Pessoa cTR_Pessoa = new CTR_Pessoa();
            cTR_Pessoa.Incluir(P);

            Endereco E = new Endereco();
            E.Bairro = txtCadastroClienteJuridicoBairro.Text;
            E.CEP = txtCadastroClienteJuridicoCEP.Text;
            E.Numero = txtCadastroClienteJuridicoNumero.Text;
            E.Rua = txtCadastroClienteJuridicoRua.Text;
            E.Telefone = txtCadastroClienteJuridicoTelefones.Text;
            CTR_Endereco cTR_Endereco = new CTR_Endereco();
            cTR_Endereco.Incluir(E);

            PessoaJuridica PJ=new PessoaJuridica();
            PJ.CNPJ = txtCadastroClienteJuridicoCNPJ.Text;
            PJ.IE = txtCadastroClienteJuridicoIE.Text;
            CTR_PessoaJuridica cTR_PessoaJuridica = new CTR_PessoaJuridica();
            cTR_PessoaJuridica.Incluir(PJ);
            
        }
    }
}
