namespace AppContatos.Formularios
{
    partial class BuscarContatos
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
            this.components = new System.ComponentModel.Container();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.bsContatos = new System.Windows.Forms.BindingSource(this.components);
            this.btCadastrarContato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(9, 71);
            this.dgvContatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.RowHeadersWidth = 51;
            this.dgvContatos.RowTemplate.Height = 24;
            this.dgvContatos.Size = new System.Drawing.Size(582, 285);
            this.dgvContatos.TabIndex = 0;
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.Location = new System.Drawing.Point(9, 11);
            this.btCadastrarContato.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(138, 45);
            this.btCadastrarContato.TabIndex = 1;
            this.btCadastrarContato.Text = "Cadastrar";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // BuscarContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btCadastrarContato);
            this.Controls.Add(this.dgvContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarContatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.BindingSource bsContatos;
        private System.Windows.Forms.Button btCadastrarContato;
    }
}