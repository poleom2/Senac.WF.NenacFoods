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
    public partial class FrmCardapioCad2 : Form
    {
        public FrmCardapioCad2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
        {
            //conectar
            using (var banco = new ComandaDBContest())
            {

                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;

                //criar um novo item cardapio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };

                //adiciona o cardapio
                banco.CardapioItems.Add(cardapio);

                //salva as alterações
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salva com suceso!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
