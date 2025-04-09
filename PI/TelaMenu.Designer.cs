namespace PI
{
    partial class TelaMenu
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConsultarProjetos = new System.Windows.Forms.Button();
            this.buttonConsultarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonSair.Location = new System.Drawing.Point(306, 317);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(190, 44);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonConsultarProjetos
            // 
            this.buttonConsultarProjetos.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConsultarProjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonConsultarProjetos.Location = new System.Drawing.Point(461, 226);
            this.buttonConsultarProjetos.Name = "buttonConsultarProjetos";
            this.buttonConsultarProjetos.Size = new System.Drawing.Size(193, 44);
            this.buttonConsultarProjetos.TabIndex = 9;
            this.buttonConsultarProjetos.Text = "Consultar Projetos";
            this.buttonConsultarProjetos.UseVisualStyleBackColor = false;
            this.buttonConsultarProjetos.Click += new System.EventHandler(this.buttonConsultarProjetos_Click);
            // 
            // buttonConsultarUsuario
            // 
            this.buttonConsultarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonConsultarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonConsultarUsuario.Location = new System.Drawing.Point(147, 226);
            this.buttonConsultarUsuario.Name = "buttonConsultarUsuario";
            this.buttonConsultarUsuario.Size = new System.Drawing.Size(193, 44);
            this.buttonConsultarUsuario.TabIndex = 8;
            this.buttonConsultarUsuario.Text = "Consultar Usuário";
            this.buttonConsultarUsuario.UseVisualStyleBackColor = false;
            this.buttonConsultarUsuario.Click += new System.EventHandler(this.buttonConsultarUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(323, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu Principal";
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonConsultarProjetos);
            this.Controls.Add(this.buttonConsultarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "TelaMenu";
            this.Text = "TelaMenu";
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConsultarProjetos;
        private System.Windows.Forms.Button buttonConsultarUsuario;
        private System.Windows.Forms.Label label1;
    }
}