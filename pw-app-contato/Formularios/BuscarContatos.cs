using AppContatos.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContatos.Formularios
{
    public partial class BuscarContatos : Form
    {
        public BuscarContatos()
        {
            InitializeComponent();

            ConfigurarDados();
        }

        private void ConfigurarDados()
        {
            bsContatos.DataSource = Contexto.ListarContatos().ToArray();
            dgvContatos.DataSource = bsContatos;
        }

        private void btCadastrarContato_Click(object sender, EventArgs e)
        {
            var form = new FormContato();
            form.ShowDialog();
        }
    }
}
