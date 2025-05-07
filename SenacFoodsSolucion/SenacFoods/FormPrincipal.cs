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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(string nome, string senha)
        {
            InitializeComponent();
            lblMensagem.Text = " Bem vindo " + nome;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            var formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            var frmCardapio = new FrmCardapio();
            frmCardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            var frmCardapio = new FrmCardapio();
            frmCardapio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmPedidoDoCozinha = new FrmPedidoDoCozinha();
            frmPedidoDoCozinha.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var fmrUsuario = new FrmUsuario();
            fmrUsuario.ShowDialog();
        }
    }
}
