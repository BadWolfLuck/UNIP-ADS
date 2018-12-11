using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim.View
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteFisicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCadastroPessoaFisica FRMCadastroPessoaFisica = new FRMCadastroPessoaFisica();
            FRMCadastroPessoaFisica.MdiParent = this;
            FRMCadastroPessoaFisica.Show(); 
        }

        private void clienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCadastroPessoaJuridica FRMCadastroPessoaJuridica = new FRMCadastroPessoaJuridica();
            FRMCadastroPessoaJuridica.MdiParent = this;
            FRMCadastroPessoaJuridica.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCadastroFuncionario FRMCadastroFucionario = new FRMCadastroFuncionario();
            FRMCadastroFucionario.MdiParent = this;
            FRMCadastroFucionario.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCadastroServico FRMCadasstroServico = new FRMCadastroServico();
            FRMCadasstroServico.MdiParent = this;
            FRMCadasstroServico.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMCadastroImpressora FRMCadastroImpressora = new FRMCadastroImpressora();
            FRMCadastroImpressora.MdiParent = this;
            FRMCadastroImpressora.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMCadastroPeca FRMCadastroPeca = new FRMCadastroPeca();
            FRMCadastroPeca.MdiParent = this;
            FRMCadastroPeca.Show();
        }

        private void clienteFisicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMConsultarPessoaFisica FRMConsultarPessoaFisica = new FRMConsultarPessoaFisica();
            FRMConsultarPessoaFisica.MdiParent = this;
            FRMConsultarPessoaFisica.Show();
        }

        private void clienteJuridicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMConsultarPessoaJuridica FRMConsultarPessoaJuridica = new FRMConsultarPessoaJuridica();
            FRMConsultarPessoaJuridica.MdiParent = this;
            FRMConsultarPessoaJuridica.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMConsultarFuncionario FRMConsultarFuncionario = new FRMConsultarFuncionario();
            FRMConsultarFuncionario.MdiParent = this;
            FRMConsultarFuncionario.Show();
        }

        private void consultarAlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMConsultarServico FRMConsultarServico = new FRMConsultarServico();
            FRMConsultarServico.MdiParent = this;
            FRMConsultarServico.Show();
        }
    }
}
