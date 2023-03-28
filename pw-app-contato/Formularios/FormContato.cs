using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContatos.RegrasDeNegocio;
using MySql.Data.MySqlClient;

namespace AppContatos.Formularios
{
    public partial class FormContato : Form
    {
        private int Id;

        public FormContato()
        {
            InitializeComponent();
        }

        

        private void SetComponentesEnabled(bool isEnabled)
        {
            edNome.Enabled = isEnabled;
            edEmail.Enabled = isEnabled;
            edTelefone.Enabled = isEnabled;
            rbMasc.Enabled = isEnabled;
            rbFem.Enabled = isEnabled;
            edCpf.Enabled = isEnabled;
            dtpDataNasc.Enabled = isEnabled;
        }


        private void FecharComponentes()
        {
            this.SetComponentesEnabled(false);
        }


        private void LiberarComponentes()
        {
            this.SetComponentesEnabled(true);
        }

        private void LimparComponentes()
        {
            edNome.Clear();
            edEmail.Clear();
            edTelefone.Clear();
            edCpf.Clear();
            dtpDataNasc.Value = DateTime.Now;
        }

        private bool ChecarFormulario()
        {            

            
            var nome = this.edNome.Text.Trim();

            if(nome == String.Empty)
            {
                return false;
            }

            var email = this.edEmail.Text;

            if(email == String.Empty)
            {
                return false;
            }


            var cpf = this.edCpf.Text;

            if(cpf ==  String.Empty)
            {
                return false;
            }

            var telefone = this.edTelefone.Text;

            if(telefone == String.Empty)
            {
                return false;
            }

            if(!rbMasc.Checked && !rbFem.Checked)
            {
                return false;
            }


            var dataNascimento = dtpDataNasc.Value;

            if (dataNascimento > DateTime.Now)
            {
                return false;
            }

            return true;
        }

        private Contato ConsultarEstado()
        {
            var id = this.Id;
            var nome = this.edNome.Text;
            var email = this.edEmail.Text;
            var cpf = this.edCpf.Text;
            var telefone = this.edTelefone.Text;
            var sexo = rbMasc.Checked ? "M" : "F";
            var dataNascimento = dtpDataNasc.Value;


            var contato = new Contato();
            contato.Id = id;
            contato.Nome = nome;
            contato.Email = email;
            contato.CPF = cpf;
            contato.Telefone = telefone;
            contato.Sexo = sexo;
            contato.DataNascimento = dataNascimento;
            

            return contato;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if(!this.ChecarFormulario())
            {
                MessageBox.Show("Formulário inválido!");
                return;
            }
 
            try
            {
                var contato = this.ConsultarEstado();

                Contexto.SalvarContato(contato);

                LimparComponentes();


                var opcao = MessageBox.Show("Contato salvo com sucesso! Deseja cadastrar um novo contato?", "Cadastrar Contato", MessageBoxButtons.YesNo);

                if(opcao == DialogResult.No)
                {
                    this.Close();
                }
            } catch (Exception ex) {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Ocorreram erros ao tentar salvar os dados! Contate o suporte do sistema!");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Deseja cancelar esta operação?", "AppContato", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                LimparComponentes();
            }
        }
    }
}
