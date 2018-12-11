namespace pim.View
{
    partial class FRMCadastroImpressora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloCadastroImpressora = new System.Windows.Forms.Label();
            this.lblCadastroImpressoraFabricante = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCadastroImpressoraModelo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCadastroImpressoraGravar = new System.Windows.Forms.Button();
            this.lblCadastroImpressoraLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloCadastroImpressora
            // 
            this.lblTituloCadastroImpressora.AutoSize = true;
            this.lblTituloCadastroImpressora.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloCadastroImpressora.Location = new System.Drawing.Point(366, 72);
            this.lblTituloCadastroImpressora.Name = "lblTituloCadastroImpressora";
            this.lblTituloCadastroImpressora.Size = new System.Drawing.Size(193, 21);
            this.lblTituloCadastroImpressora.TabIndex = 0;
            this.lblTituloCadastroImpressora.Text = "Cadastrar Impressora";
            // 
            // lblCadastroImpressoraFabricante
            // 
            this.lblCadastroImpressoraFabricante.AutoSize = true;
            this.lblCadastroImpressoraFabricante.Location = new System.Drawing.Point(285, 209);
            this.lblCadastroImpressoraFabricante.Name = "lblCadastroImpressoraFabricante";
            this.lblCadastroImpressoraFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblCadastroImpressoraFabricante.TabIndex = 1;
            this.lblCadastroImpressoraFabricante.Text = "Fabricante:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCadastroImpressoraModelo
            // 
            this.lblCadastroImpressoraModelo.AutoSize = true;
            this.lblCadastroImpressoraModelo.Location = new System.Drawing.Point(285, 255);
            this.lblCadastroImpressoraModelo.Name = "lblCadastroImpressoraModelo";
            this.lblCadastroImpressoraModelo.Size = new System.Drawing.Size(45, 13);
            this.lblCadastroImpressoraModelo.TabIndex = 4;
            this.lblCadastroImpressoraModelo.Text = "Modelo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnCadastroImpressoraGravar
            // 
            this.btnCadastroImpressoraGravar.Location = new System.Drawing.Point(351, 315);
            this.btnCadastroImpressoraGravar.Name = "btnCadastroImpressoraGravar";
            this.btnCadastroImpressoraGravar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroImpressoraGravar.TabIndex = 6;
            this.btnCadastroImpressoraGravar.Text = "Gravar";
            this.btnCadastroImpressoraGravar.UseVisualStyleBackColor = true;
            // 
            // lblCadastroImpressoraLimpar
            // 
            this.lblCadastroImpressoraLimpar.Location = new System.Drawing.Point(487, 315);
            this.lblCadastroImpressoraLimpar.Name = "lblCadastroImpressoraLimpar";
            this.lblCadastroImpressoraLimpar.Size = new System.Drawing.Size(75, 23);
            this.lblCadastroImpressoraLimpar.TabIndex = 7;
            this.lblCadastroImpressoraLimpar.Text = "Limpar";
            this.lblCadastroImpressoraLimpar.UseVisualStyleBackColor = true;
            // 
            // FRMCadastroImpressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 691);
            this.Controls.Add(this.lblCadastroImpressoraLimpar);
            this.Controls.Add(this.btnCadastroImpressoraGravar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCadastroImpressoraModelo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCadastroImpressoraFabricante);
            this.Controls.Add(this.lblTituloCadastroImpressora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMCadastroImpressora";
            this.Text = "FRMCadastroImpressora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastroImpressora;
        private System.Windows.Forms.Label lblCadastroImpressoraFabricante;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCadastroImpressoraModelo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCadastroImpressoraGravar;
        private System.Windows.Forms.Button lblCadastroImpressoraLimpar;
    }
}