using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmUsuariosCadastrados : Form
    {
        private Usuario _Usuario;
        public FrmUsuariosCadastrados()
        {
            InitializeComponent();
        }
        public FrmUsuariosCadastrados(Usuario usuario)
        {
            _Usuario = usuario;
            InitializeComponent();
            CarreagarDasoaDaTela();
        }

        private void CarreagarDasoaDaTela()
        {
            if (_Usuario != null)
            {
                txtName.Text = _Usuario.Name;
                txtEmail.Text = _Usuario.Email;
                txtSenha.Text = _Usuario.Senha;
                chkActivo.Checked = _Usuario.Ativo;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (_Usuario != null)
            {
                InserirCardapio();
            }
            else
            {
                AtualizarCardapio();

            }
        }

        private void AtualizarCardapio()
        {
            throw new NotImplementedException();
        }

        private void InserirCardapio()
        {
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                string Name = txtName.Text;
                string Email = txtEmail.Text;
                string Senha = txtSenha.Text;
                bool Estado = chkActivo.Checked;

                //criar um novo item cardapio
                var usuario = new Usuario()
                {
                    Name = Name,
                    Email = Senha,
                    Senha = Senha,
                     Ativo= Estado
                };
            }
    }
}
