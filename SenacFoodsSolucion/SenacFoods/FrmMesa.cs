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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarMesa();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }
    }
}

