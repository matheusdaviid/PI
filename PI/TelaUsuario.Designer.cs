namespace PI
{
    partial class TelaUsuario
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
            this.buttonListarUsuarios = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(556, 346);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(185, 42);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonListarUsuarios
            // 
            this.buttonListarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarUsuarios.Location = new System.Drawing.Point(556, 167);
            this.buttonListarUsuarios.Name = "buttonListarUsuarios";
            this.buttonListarUsuarios.Size = new System.Drawing.Size(185, 42);
            this.buttonListarUsuarios.TabIndex = 9;
            this.buttonListarUsuarios.Text = "Listar Usuários";
            this.buttonListarUsuarios.UseVisualStyleBackColor = true;
            this.buttonListarUsuarios.Click += new System.EventHandler(this.buttonListarUsuarios_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(60, 167);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(345, 221);
            this.dataGridViewUsuarios.TabIndex = 8;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listar Usuários";
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonListarUsuarios);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "TelaUsuario";
            this.Text = "TelaUsuario";
            this.Load += new System.EventHandler(this.TelaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonListarUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label label1;
    }
}