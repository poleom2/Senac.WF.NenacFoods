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
        private CardapioItem _CardapioItem;

        public FrmCardapioCad2()
        {
            InitializeComponent();
        }
        public FrmCardapioCad2(CardapioItem cardapioItem)
        {
            _CardapioItem = cardapioItem;
            InitializeComponent();
            CarreagarDasoaDaTela();

        }

        private void CarreagarDasoaDaTela()
        {
            if (_CardapioItem != null)
            {
                txtTitulo.Text = _CardapioItem.Titulo;
                txtDescricao.Text = _CardapioItem.Descricao;
                txtPreco.Text = _CardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _CardapioItem.PossuiPreparo;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_CardapioItem != null)
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
            using (var banco = new ComandaDBContest())
            {
                string Titulo =txtTitulo.Text;
                string descricao =txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;

                var cardapioItem = banco.CardapioItems.First(x => x.Id == _CardapioItem.Id);
                cardapioItem.Titulo = Titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;

                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();


            }
        }

        private void InserirCardapio()
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
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();    
        }
    }
}
