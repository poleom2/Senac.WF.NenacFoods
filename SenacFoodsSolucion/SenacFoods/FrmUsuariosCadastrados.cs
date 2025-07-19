using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace SenacFoods
{
    public partial class FrmUsuariosCadastrados : Form
    {
        private Usuario _Usuario;

        public string IsNullorEmpay { get; private set; }

        public FrmUsuariosCadastrados()
        {
            InitializeComponent();
            errorProvider1.Clear();
        }
        public FrmUsuariosCadastrados(Usuario usuario)
        {
            _Usuario = usuario;
            InitializeComponent();
            CarreagarDasoaDaTela();
            errorProvider1.Clear();
        }

        private void CarreagarDasoaDaTela()
        {
            if (_Usuario != null)
            {
                txtName.Text = _Usuario.Name;
                txtEmail.Text = _Usuario.Email;
                txtSenha.Text = _Usuario.Senha;


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (_Usuario == null)
            {
                InserirUsuario();
            }
            else
            {
                AtualizarUsuario();

            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContest())
            {
                string Name = txtName.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;

                var usuario = banco.Usuarios.First(x => x.Id == _Usuario.Id);
                usuario.Name = Name;
                usuario.Email = Email;
                usuario.Senha = Senha;
                
                var isDadosDoUsuarioValidos = _validaCamposParaAtualizarUsuario();

                if (isDadosDoUsuarioValidos == false) return;

                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
                MessageBox.Show("Senha cadastrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

        private bool _validaCamposParaAtualizarUsuario()
        {
            errorProvider1.Clear();

            if (txtSenha.Text.Length > 6)
            {
                errorProvider1.SetError(txtSenha, "A senha não pode ter mais que 6 dígitos.");
                
            }
            if (txtSenha.Text != txtComfirmarSenha.Text)
            {
                errorProvider1.SetError(txtComfirmarSenha, "As senhas não coincidem.");
   
            }
            if (txtName.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtName, "O campo NAME é obrigatório.");
            }
            if (txtSenha.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtSenha, "O campo SENHA é obrigatório.");
            }

            if (!errorProvider1.HasErrors) return true;

            return false;
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContest())
            {


                string Name = txtName.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;



                var usuario = new Usuario()
                {
                    Name = Name,
                    Email = Senha,
                    Senha = Senha,
                };

                var isDadosDoUsuarioValidos = _validaCamposParaAtualizarUsuario();

                if (isDadosDoUsuarioValidos == false) return;

                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
                MessageBox.Show("Senha cadastrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
