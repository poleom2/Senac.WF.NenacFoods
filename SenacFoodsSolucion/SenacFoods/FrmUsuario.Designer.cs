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
            groupBox1 = new GroupBox();
            btnExcluir = new Button();
            btnItemC = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
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
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(137, 16);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(821, 31);
            txtPesquisa.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnItemC);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(11, 89);
            groupBox1.Margin = new Padding(2, 4, 2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 4, 2, 4);
            groupBox1.Size = new Size(1034, 475);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(788, 437);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnItemC
            // 
            btnItemC.BackColor = Color.Lime;
            btnItemC.FlatAppearance.BorderSize = 0;
            btnItemC.FlatStyle = FlatStyle.Flat;
            btnItemC.Location = new Point(0, 37);
            btnItemC.Name = "btnItemC";
            btnItemC.Size = new Size(112, 34);
            btnItemC.TabIndex = 5;
            btnItemC.Text = "Adicionar";
            btnItemC.UseVisualStyleBackColor = false;
            btnItemC.Click += btnItem_Click;
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 10;
            label1.Text = "Pesquisa";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(1047, 575);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private Button btnItemC;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Button btnExcluir;
        private Label label1;
    }
}