using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Servicoss;

namespace WpfApp1.Janelas
{
    /// <summary>
    /// Lógica interna para BuscarContatos.xaml
    /// </summary>
    public partial class BuscarContatos : Window
    {
        public BuscarContatos()
        {
            InitializeComponent();

            BuscarDados();
        }

        private void BuscarDados()
        {
            var contatos = Contexto.ListarContatos();

            dgItems.ItemsSource = contatos;
        }
    }
}
