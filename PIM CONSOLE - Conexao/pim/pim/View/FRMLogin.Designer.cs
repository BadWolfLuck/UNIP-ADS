namespace pim.View
{
    partial class FRMLogin
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
            this.lblLoginLogin = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.txtLoginLogin = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.btnLoginLogar = new System.Windows.Forms.Button();
            this.btnLoginSair = new System.Windows.Forms.Button();
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoginLogin
            // 
            this.lblLoginLogin.AutoSize = true;
            this.lblLoginLogin.Location = new System.Drawing.Point(156, 76);
            this.lblLoginLogin.Name = "lblLoginLogin";
            this.lblLoginLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLoginLogin.TabIndex = 0;
            this.lblLoginLogin.Text = "Login:";
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Location = new System.Drawing.Point(156, 114);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(41, 13);
            this.lblLoginSenha.TabIndex = 1;
            this.lblLoginSenha.Text = "Senha:";
            // 
            // txtLoginLogin
            // 
            this.txtLoginLogin.Location = new System.Drawing.Point(198, 76);
            this.txtLoginLogin.Name = "txtLoginLogin";
            this.txtLoginLogin.Size = new System.Drawing.Size(159, 20);
            this.txtLoginLogin.TabIndex = 2;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(198, 114);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(159, 20);
            this.txtLoginSenha.TabIndex = 3;
            // 
            // btnLoginLogar
            // 
            this.btnLoginLogar.Location = new System.Drawing.Point(198, 140);
            this.btnLoginLogar.Name = "btnLoginLogar";
            this.btnLoginLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginLogar.TabIndex = 4;
            this.btnLoginLogar.Text = "Logar";
            this.btnLoginLogar.UseVisualStyleBackColor = true;
            this.btnLoginLogar.Click += new System.EventHandler(this.btnLoginLogar_Click);
            // 
            // btnLoginSair
            // 
            this.btnLoginSair.Location = new System.Drawing.Point(282, 140);
            this.btnLoginSair.Name = "btnLoginSair";
            this.btnLoginSair.Size = new System.Drawing.Size(75, 23);
            this.btnLoginSair.TabIndex = 5;
            this.btnLoginSair.Text = "Sair";
            this.btnLoginSair.UseVisualStyleBackColor = true;
            this.btnLoginSair.Click += new System.EventHandler(this.btnLoginSair_Click);
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitulo.Location = new System.Drawing.Point(221, 30);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(116, 21);
            this.lblLoginTitulo.TabIndex = 6;
            this.lblLoginTitulo.Text = "Perepentech";
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 253);
            this.Controls.Add(this.lblLoginTitulo);
            this.Controls.Add(this.btnLoginSair);
            this.Controls.Add(this.btnLoginLogar);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginLogin);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblLoginLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginLogin;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.TextBox txtLoginLogin;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Button btnLoginLogar;
        private System.Windows.Forms.Button btnLoginSair;
        private System.Windows.Forms.Label lblLoginTitulo;
    }
}