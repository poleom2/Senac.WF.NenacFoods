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
    public partial class FrmUsuario : Form
    {
        Usuario? UsuarioSelecionado;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void BuscarUsuario()
        {
            using (var bd = new ComandaDBContest())
            {
                var usuario = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    usuario = usuario.Where(u => u.Name.Contains(txtPesquisa.Text) ||
                                                    u.Email.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuario.ToList();
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            new FrmUsuariosCadastrados().ShowDialog();
            BuscarUsuario();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;

            }
        }

       

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {


                using (var bancoDeDados = new ComandaDBContest())
                {
                    bancoDeDados.Usuarios.Remove(UsuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Usuario excluido com suceso!", "Suceso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuario();
                UsuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um Usuario para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var frmEditar = new FrmUsuariosCadastrados(UsuarioSelecionado);
                frmEditar.ShowDialog();
                BuscarUsuario();
                UsuarioSelecionado = null;
            }
        }
    }
}