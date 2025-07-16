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
        private Mesa _Mesa;


        public FrmMesaCad()
        {
            InitializeComponent();
        }
        public FrmMesaCad(Mesa frmMesaCad)
        {
            _Mesa = frmMesaCad;
            InitializeComponent();
            CarreagarDasoaDaTela();
        }

        private void CarreagarDasoaDaTela()
        {
            if (_Mesa != null)
            {
                txtNumeroMesa.Text = _Mesa.NumeroMesa.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Mesa == null)
            {
                InserirMesa();
               
            }
            else
            {
                AtualizarMesa();

            }
        }

        private void AtualizarMesa()
        {
            using(var banco = new ComandaDBContest())
            {
                

                var mesa = banco.Mesas.First(x => x.Id == _Mesa.Id);

                int.TryParse(txtNumeroMesa.Text, out var NumeroMesa);

                mesa.NumeroMesa = NumeroMesa;
                banco.Mesas.Update(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Seu Cadastro foi alteradou com suceso!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirMesa()
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
