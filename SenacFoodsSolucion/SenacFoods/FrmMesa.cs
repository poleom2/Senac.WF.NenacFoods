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
    public partial class FrmMesa : Form
    {
        Mesa? MesaSelacionado;
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void BuscarMesa()
        {
            using (var bd = new ComandaDBContest())
            {
                var mesa = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    mesa = mesa.Where(m => m.NumeroMesa == int.Parse(txtPesquisa.Text));
                }
                dataGridView1.DataSource = mesa.ToList();
            }
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            var frmmesacad = new FrmMesaCad();
            frmmesacad.ShowDialog();
            BuscarMesa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MesaSelacionado != null)
            {


                using (var bancoDeDados = new ComandaDBContest())
                {
                    bancoDeDados.Mesas.Remove(MesaSelacionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Mesa excluido com suceso!", "Suceso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesa();
                MesaSelacionado = null;
            }
            else
            {
                MessageBox.Show("Selecione uma mesa para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MesaSelacionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btnEditar.Enabled = true;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MesaSelacionado != null)
            {
                var MEditar = new FrmMesaCad(MesaSelacionado);
                MEditar.ShowDialog();
                BuscarMesa();
                MesaSelacionado = null;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

