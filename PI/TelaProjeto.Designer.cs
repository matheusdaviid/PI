namespace PI
{
    partial class TelaProjeto
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
            this.ButtonSair = new System.Windows.Forms.Button();
            this.ButtonListarProjetos = new System.Windows.Forms.Button();
            this.DataGridViewProjetos = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSair
            // 
            this.ButtonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSair.Location = new System.Drawing.Point(184, 278);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(185, 42);
            this.ButtonSair.TabIndex = 15;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // ButtonListarProjetos
            // 
            this.ButtonListarProjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonListarProjetos.Location = new System.Drawing.Point(184, 153);
            this.ButtonListarProjetos.Name = "ButtonListarProjetos";
            this.ButtonListarProjetos.Size = new System.Drawing.Size(185, 42);
            this.ButtonListarProjetos.TabIndex = 14;
            this.ButtonListarProjetos.Text = "Listar Projetos";
            this.ButtonListarProjetos.UseVisualStyleBackColor = true;
            this.ButtonListarProjetos.Click += new System.EventHandler(this.ButtonListarProjetos_Click);
            // 
            // DataGridViewProjetos
            // 
            this.DataGridViewProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProjetos.Location = new System.Drawing.Point(497, 92);
            this.DataGridViewProjetos.Name = "DataGridViewProjetos";
            this.DataGridViewProjetos.Size = new System.Drawing.Size(271, 330);
            this.DataGridViewProjetos.TabIndex = 13;
            this.DataGridViewProjetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProjetos_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Silver;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(267, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(203, 31);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Listar Projetos";
            // 
            // TelaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonListarProjetos);
            this.Controls.Add(this.DataGridViewProjetos);
            this.Controls.Add(this.Label1);
            this.Name = "TelaProjeto";
            this.Text = "TelaProjeto";
            this.Load += new System.EventHandler(this.TelaProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.Button ButtonListarProjetos;
        private System.Windows.Forms.DataGridView DataGridViewProjetos;
        private System.Windows.Forms.Label Label1;
    }
}