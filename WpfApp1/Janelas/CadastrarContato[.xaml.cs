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
using WpfApp1.Models;

namespace WpfApp1.Janelas
{
    /// <summary>
    /// Lógica interna para CadastrarContato_.xaml
    /// </summary>
    public partial class CadastrarContato_ : Window
    {
        public CadastrarContato_()
        {
            InitializeComponent();

            LimparFormulario();
        }

        private void LimparFormulario()
        {
            edNome.Clear();
            edEmail.Clear();
            edTelefone.Clear();
            edCpf.Clear();
            dtDataDeNascimento.SelectedDate = null;

            rbMasculino.IsChecked = false;
            rbFeminino.IsChecked = false;

            edNome.Focus();
        }

        private string ConsultarEstadoSexo()
        {
            if(rbMasculino.IsChecked == true)
            {
                return "M";
            }

            if(rbFeminino.IsChecked==true)
            {
                return "F";
            }

            return string.Empty;
        }

        private Contato ConsultarEstado()
        {
            var contato = new Contato();

            contato.Nome = edNome.Text.Trim();
            contato.Email = edEmail.Text.Trim();
            contato.Telefone = edTelefone.Text.Trim();
            contato.CPF = edCpf.Text.Trim();

            contato.Sexo = ConsultarEstadoSexo();

            var dataDeNascimento = dtDataDeNascimento.SelectedDate;

            if(dataDeNascimento != null)
            {
                contato.DataNascimento = (DateTime)dataDeNascimento;
            }

            return contato;
        }

        private bool ValidarFormulario()
        {
            if(
                
                edNome.Text.Trim().Length == 0 ||
                edEmail.Text.Trim().Length == 0 ||
                edTelefone.Text.Trim().Length == 0 ||
                edCpf.Text.Trim().Length == 0 ||
               
                (
                    (rbMasculino.IsChecked != true || rbFeminino.IsChecked != true) == false 
                ) ||

                dtDataDeNascimento.SelectedDate == null
                )
            {
                return false;
            }

            return true;
        }

        private bool ChecarFormulario()
        {
            var valido = ValidarFormulario();

            if (!valido)
            {
                MessageBox.Show("Preencha corretamente todos os campos obrigatórios do formulário!", "Cadastrar Contato");
            }


            return valido;
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if(ChecarFormulario())
            {



                var result = MessageBox.Show("Deseja adicionar mais contatos?", "Cadastrar Contato", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    LimparFormulario();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar esta operação?", "Cadastrar Contato", MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
