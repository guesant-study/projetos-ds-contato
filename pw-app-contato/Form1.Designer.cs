namespace AppContatos
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
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.btBuscarContatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.Location = new System.Drawing.Point(12, 12);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(255, 55);
            this.btCadastrarContato.TabIndex = 0;
            this.btCadastrarContato.Text = "Cadastrar Contato";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // btBuscarContatos
            // 
            this.btBuscarContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarContatos.Location = new System.Drawing.Point(12, 82);
            this.btBuscarContatos.Name = "btBuscarContatos";
            this.btBuscarContatos.Size = new System.Drawing.Size(255, 55);
            this.btBuscarContatos.TabIndex = 2;
            this.btBuscarContatos.Text = "Buscar Contatos";
            this.btBuscarContatos.UseVisualStyleBackColor = true;
            this.btBuscarContatos.Click += new System.EventHandler(this.btBuscarContatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 150);
            this.Controls.Add(this.btBuscarContatos);
            this.Controls.Add(this.btCadastrarContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppContatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Button btBuscarContatos;
    }
}

