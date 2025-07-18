
namespace SenacFoods
{
    partial class FrmCardapio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnItemC = new Button();
            btnEscluir = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            txtPesquisa = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            btnFechar = new Button();
            btnExcluir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnItemC);
            groupBox1.Controls.Add(btnEscluir);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(5, 99);
            groupBox1.Margin = new Padding(2, 4, 2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 4, 2, 4);
            groupBox1.Size = new Size(1034, 475);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnItemC
            // 
            btnItemC.BackColor = Color.Lime;
            btnItemC.Location = new Point(18, 37);
            btnItemC.Name = "btnItemC";
            btnItemC.Size = new Size(112, 34);
            btnItemC.TabIndex = 5;
            btnItemC.Text = "+ Item";
            btnItemC.UseVisualStyleBackColor = false;
            btnItemC.Click += btnItemC_Click;
            // 
            // btnEscluir
            // 
            btnEscluir.BackColor = Color.Red;
            btnEscluir.Location = new Point(772, 434);
            btnEscluir.Margin = new Padding(2, 4, 2, 4);
            btnEscluir.Name = "btnEscluir";
            btnEscluir.Size = new Size(134, 41);
            btnEscluir.TabIndex = 3;
            btnEscluir.Text = "Escluir";
            btnEscluir.UseVisualStyleBackColor = false;
            btnEscluir.Click += btnEscluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Lime;
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(896, 434);
            btnEditar.Margin = new Padding(2, 4, 2, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(134, 41);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1028, 350);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(131, 26);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(821, 37);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(964, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 44);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(5, 26);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 35);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Pesquisa";
            btnExcluir.Click += this.btnExcluir_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1045, 581);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(btnExcluir);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            Load += FrmCardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private TextBox txtPesquisa;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button btnItemC;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button btnFechar;
        private Button btnEscluir;
        private Button btnExcluir;
    }
}