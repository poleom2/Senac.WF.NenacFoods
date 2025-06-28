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
            btn = new Button();
            groupBox1 = new GroupBox();
            btnItemC = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.Red;
            btn.Location = new Point(752, 434);
            btn.Margin = new Padding(2, 4, 2, 4);
            btn.Name = "btn";
            btn.Size = new Size(134, 41);
            btn.TabIndex = 1;
            btn.Text = "Excluir";
            btn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnItemC);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(5, 84);
            groupBox1.Margin = new Padding(2, 4, 2, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 4, 2, 4);
            groupBox1.Size = new Size(1034, 475);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // btnItemC
            // 
            btnItemC.BackColor = Color.Lime;
            btnItemC.Location = new Point(27, 35);
            btnItemC.Name = "btnItemC";
            btnItemC.Size = new Size(112, 34);
            btnItemC.TabIndex = 5;
            btnItemC.Text = "+ Item";
            btnItemC.UseVisualStyleBackColor = false;
            btnItemC.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(878, 434);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 3;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 76);
            dataGridView1.Margin = new Padding(2, 4, 2, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(975, 350);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 22);
            textBox1.Margin = new Padding(2, 4, 2, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(736, 37);
            textBox1.TabIndex = 4;
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
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(988, 12);
            button3.Name = "button3";
            button3.Size = new Size(51, 34);
            button3.TabIndex = 5;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1045, 564);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
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

        private Button btn;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button2;
        private Button btnItemC;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button button3;
    }
}