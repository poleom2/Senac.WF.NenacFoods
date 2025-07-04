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
    public partial class FrmMesaCad : Form
    {
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
        }

        private void SalvarMesa()
        {
            using (var banco = new ComandaDBContest())
            {
                int.TryParse(txtNumeroMesa.Text, out var numeroMesa);
                var mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa
                };
                banco.Mesas.Add(mesa);

                banco.SaveChanges();
            }
            MessageBox.Show("Seu Cadastro se salvou com suceso!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
