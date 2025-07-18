namespace SenacFoods
{
    partial class FrmUsuario
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
            btnFechar = new Button();
            txtPesquisa = new TextBox();
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            btnItemC = new Button();
            btnEscluir = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(970, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 44);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(137, 16);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(821, 31);
            txtPesquisa.TabIndex = 8;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(11, 16);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 35);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Pesquisa";
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnItemC);
            groupBox1.Controls.Add(btnEscluir);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(11, 89);
            groupBox1.Margin = new Padding(2, 4, 2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 4, 2, 4);
            groupBox1.Size = new Size(1034, 475);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1028, 350);
            dataGridView1.TabIndex = 6;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(1047, 575);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(btnExcluir);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtPesquisa;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private Button btnItemC;
        private Button btnEscluir;
        private Button btnEditar;
        private DataGridView dataGridView1;
    }
}