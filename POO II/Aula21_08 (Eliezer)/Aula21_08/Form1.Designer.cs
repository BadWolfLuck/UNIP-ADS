namespace Aula21_08
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnAddPF = new System.Windows.Forms.Button();
            this.btnAddPJ = new System.Windows.Forms.Button();
            this.btnLe_pf = new System.Windows.Forms.Button();
            this.btnLe_pj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(56, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(56, 117);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(56, 210);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(269, 210);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 6;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(59, 149);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(176, 20);
            this.txtSobrenome.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(59, 241);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(176, 20);
            this.txtCpf.TabIndex = 9;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(272, 241);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(176, 20);
            this.txtCnpj.TabIndex = 10;
            // 
            // btnAddPF
            // 
            this.btnAddPF.Location = new System.Drawing.Point(59, 320);
            this.btnAddPF.Name = "btnAddPF";
            this.btnAddPF.Size = new System.Drawing.Size(75, 23);
            this.btnAddPF.TabIndex = 11;
            this.btnAddPF.Text = "ADDPF";
            this.btnAddPF.UseVisualStyleBackColor = true;
            this.btnAddPF.Click += new System.EventHandler(this.btnAddPF_Click);
            // 
            // btnAddPJ
            // 
            this.btnAddPJ.Location = new System.Drawing.Point(176, 320);
            this.btnAddPJ.Name = "btnAddPJ";
            this.btnAddPJ.Size = new System.Drawing.Size(75, 23);
            this.btnAddPJ.TabIndex = 12;
            this.btnAddPJ.Text = "ADDPJ";
            this.btnAddPJ.UseVisualStyleBackColor = true;
            this.btnAddPJ.Click += new System.EventHandler(this.btnAddPJ_Click);
            // 
            // btnLe_pf
            // 
            this.btnLe_pf.Location = new System.Drawing.Point(59, 373);
            this.btnLe_pf.Name = "btnLe_pf";
            this.btnLe_pf.Size = new System.Drawing.Size(75, 23);
            this.btnLe_pf.TabIndex = 13;
            this.btnLe_pf.Text = "LE_PF";
            this.btnLe_pf.UseVisualStyleBackColor = true;
            this.btnLe_pf.Click += new System.EventHandler(this.btnLe_pf_Click);
            // 
            // btnLe_pj
            // 
            this.btnLe_pj.Location = new System.Drawing.Point(176, 373);
            this.btnLe_pj.Name = "btnLe_pj";
            this.btnLe_pj.Size = new System.Drawing.Size(75, 23);
            this.btnLe_pj.TabIndex = 14;
            this.btnLe_pj.Text = "LE_PJ";
            this.btnLe_pj.UseVisualStyleBackColor = true;
            this.btnLe_pj.Click += new System.EventHandler(this.btnLe_pj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 477);
            this.Controls.Add(this.btnLe_pj);
            this.Controls.Add(this.btnLe_pf);
            this.Controls.Add(this.btnAddPJ);
            this.Controls.Add(this.btnAddPF);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnAddPF;
        private System.Windows.Forms.Button btnAddPJ;
        private System.Windows.Forms.Button btnLe_pf;
        private System.Windows.Forms.Button btnLe_pj;
    }
}

