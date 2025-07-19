namespace SenacFoods
{
    partial class FrmUsuariosCadastrados
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
            components = new System.ComponentModel.Container();
            button3 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            btnSalvar = new Button();
            txtComfirmarSenha = new TextBox();
            txtSenha = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            label6 = new Label();
            btnFechar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(839, 9);
            button3.Name = "button3";
            button3.Size = new Size(51, 34);
            button3.TabIndex = 9;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtComfirmarSenha);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(1, 71);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(801, 542);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 432);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 33);
            comboBox1.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(645, 485);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 51);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtComfirmarSenha
            // 
            txtComfirmarSenha.Location = new Point(31, 331);
            txtComfirmarSenha.Margin = new Padding(4);
            txtComfirmarSenha.Name = "txtComfirmarSenha";
            txtComfirmarSenha.Size = new Size(759, 31);
            txtComfirmarSenha.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(31, 254);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(759, 31);
            txtSenha.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 78);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(759, 31);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 162);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(759, 31);
            txtEmail.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 302);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 3;
            label7.Text = "Confirmar Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 216);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 3;
            label5.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 384);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 3;
            label4.Text = "Perfil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(480, 485);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 51);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(221, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(322, 45);
            label6.TabIndex = 1;
            label6.Text = "Cadastro de Usuarios";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(753, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(49, 34);
            btnFechar.TabIndex = 11;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmUsuariosCadastrados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(807, 617);
            Controls.Add(btnFechar);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuariosCadastrados";
            Text = "FrmUsuariosCadastrados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private TextBox txtName;
        private Label label5;
        private Label label6;
        private Button btnFechar;
        private ComboBox comboBox1;
        private TextBox txtComfirmarSenha;
        private Label label7;
        private ErrorProvider errorProvider1;
    }
}