namespace SenacFoods
{
    partial class FrmCardapioCad2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            chkPossuiPreparo = new CheckBox();
            txtPreco = new TextBox();
            txtDescricao = new RichTextBox();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 45);
            label1.TabIndex = 4;
            label1.Text = "Cadastro de cardapio";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(1, 86);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(889, 519);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(725, 460);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 51);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(32, 437);
            chkPossuiPreparo.Margin = new Padding(4);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(156, 29);
            chkPossuiPreparo.TabIndex = 6;
            chkPossuiPreparo.Text = "Possui preparo";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(31, 367);
            txtPreco.Margin = new Padding(4);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(225, 31);
            txtPreco.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(31, 192);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(839, 123);
            txtDescricao.TabIndex = 4;
            txtDescricao.Text = "";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(31, 100);
            txtTitulo.Margin = new Padding(4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(839, 31);
            txtTitulo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(576, 460);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 51);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(839, 8);
            button3.Name = "button3";
            button3.Size = new Size(51, 34);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FrmCardapioCad2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(895, 606);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad2";
            Text = "FrmCardapioCad2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private CheckBox chkPossuiPreparo;
        private TextBox txtPreco;
        private RichTextBox txtDescricao;
        private TextBox txtTitulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button button3;
    }
}