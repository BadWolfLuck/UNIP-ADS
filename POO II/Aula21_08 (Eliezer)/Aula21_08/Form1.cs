using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula21_08
{
    public partial class Form1 : Form
    {
        PessoaFisica pf1;
        PessoaJuridica pj1;
        public Form1()
        {
            InitializeComponent();
            pf1 = new PessoaFisica();
            pj1 = new PessoaJuridica();
        }

        private void btnAddPF_Click(object sender, EventArgs e)
        {
            pf1.pe.nome = txtNome.Text;
            pf1.pe.sobrenome = txtSobrenome.Text;
            pf1.cpf = Convert.ToInt32(txtCpf.Text);
        }

        private void btnAddPJ_Click(object sender, EventArgs e)
        {
            pj1.nome = txtNome.Text;
            pj1.sobrenome = txtSobrenome.Text;
            pj1.cnpj = Convert.ToInt32(txtCnpj.Text);
        }

        private void btnLe_pf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + pf1.pe.nome + "\nSobreNome: " + pf1.pe.sobrenome + "\nCPF: " + pf1.cpf);
        }

        private void btnLe_pj_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("Nome: " + pj1.nome + "\nSobreNome: " + pj1.sobrenome + "\nCNPJ :" + pj1.cnpj);
            txtNome.Text = "" + pj1.nome;
            txtCnpj.Text = "" + pj1.cnpj;
        }
    }
}
