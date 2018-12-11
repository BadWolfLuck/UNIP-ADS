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
using MySql.Data.MySqlClient;
using pim.Dao;

namespace pim.View
{
    public partial class FRMLogin : Form 
    {
        private string conectar;
        private object autenticacaoDao;

        public FRMLogin()
        {
            InitializeComponent();
        }
        private void Autentificar (Autentificacao autentificacao)
        {
            CTR_Autentificacao cTR_Autentificacao = new CTR_Autentificacao();
            autentificacao.Login = txtLoginLogin.Text;
            autentificacao.Senha = txtLoginSenha.Text;
        }

        private void btnLoginSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginLogar_Click(object sender, EventArgs e)
        {
            string Login = txtLoginLogin.Text;
            string Senha = txtLoginSenha.Text;
            AutentificacaoDao autentificacaoDao = new AutentificacaoDao();
            autentificacaoDao.Logar(Login,Senha);
            string resultado = (autentificacaoDao.Logar(Login, Senha)) ? "Login efetuado comsucesso!" : "Usuario/Senha inválidos";
            MessageBox.Show(resultado);
            MDIPrincipal MDIPrincipal = new MDIPrincipal();
            MDIPrincipal.Show();
            Close();
            
        }
        
    }
}
