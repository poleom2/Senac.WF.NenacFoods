using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        CardapioItem? CardapioSelacionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }



        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using (var bd = new ComandaDBContest())
            {
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) ||
                                                    c.Descricao.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = cardapios.ToList();
            }
        }





        private void btnItemC_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad2().ShowDialog();
            BuscarCardapio();
        }






        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CardapioSelacionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btnEditar.Enabled = true;

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (CardapioSelacionado != null)
            {
                var frmEditar = new FrmCardapioCad2(CardapioSelacionado);
                frmEditar.ShowDialog();
                BuscarCardapio();
                CardapioSelacionado = null;
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEscluir_Click(object sender, EventArgs e)
        {
            if (CardapioSelacionado != null)
            {


                using (var bancoDeDados = new ComandaDBContest())
                {
                    bancoDeDados.CardapioItems.Remove(CardapioSelacionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardapio excluido com suceso!", "Suceso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                CardapioSelacionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardapio para excluir", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
