﻿using System;
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
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            using(var bd = new ComandaDBContest())
            {
                var cardapios = bd.CardapioItems.ToList();
                dataGridView1.DataSource = cardapios;
            }
        }
    }
}
