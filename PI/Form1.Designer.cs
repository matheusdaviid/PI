namespace PI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(335, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(123, 25);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "FlowTeams";
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.BackColor = System.Drawing.Color.Silver;
            this.GroupBoxLogin.Controls.Add(this.ButtonEntrar);
            this.GroupBoxLogin.Controls.Add(this.TextBoxSenha);
            this.GroupBoxLogin.Controls.Add(this.TextBoxEmail);
            this.GroupBoxLogin.Controls.Add(this.Label1);
            this.GroupBoxLogin.Controls.Add(this.Label2);
            this.GroupBoxLogin.Location = new System.Drawing.Point(154, 153);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(493, 220);
            this.GroupBoxLogin.TabIndex = 5;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "Login";
            this.GroupBoxLogin.Enter += new System.EventHandler(this.GroupBoxLogin_Enter);
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonEntrar.Enabled = false;
            this.ButtonEntrar.Location = new System.Drawing.Point(162, 173);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(142, 26);
            this.ButtonEntrar.TabIndex = 4;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = false;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click);
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(83, 131);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(297, 20);
            this.TextBoxSenha.TabIndex = 3;
            this.TextBoxSenha.TextChanged += new System.EventHandler(this.TextBoxSenha_TextChanged);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(83, 83);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(297, 20);
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(31, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Email";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(26, 135);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.GroupBoxLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Button ButtonEntrar;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
    }
}

