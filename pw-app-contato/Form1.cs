using AppContatos.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarContato_Click(object sender, EventArgs e)
        {
            var form = new FormContato();
            form.ShowDialog();
        }

        private void btBuscarContatos_Click(object sender, EventArgs e)
        {
            var form = new BuscarContatos();
            form.ShowDialog();
        }
    }
}
