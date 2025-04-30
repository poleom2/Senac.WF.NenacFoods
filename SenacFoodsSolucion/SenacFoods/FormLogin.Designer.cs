namespace SenacFoods
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnFechar = new Button();
            btnEntrar = new Button();
            textSenha = new TextBox();
            textLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(textSenha);
            panel2.Controls.Add(textLogin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Font = new Font("Segoe UI", 9F);
            panel2.Location = new Point(284, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 450);
            panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 13F);
            btnFechar.ForeColor = Color.Transparent;
            btnFechar.Location = new Point(465, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(39, 43);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(93, 276);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(248, 51);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.Red;
            textSenha.BorderStyle = BorderStyle.None;
            textSenha.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSenha.ForeColor = SystemColors.InactiveBorder;
            textSenha.Location = new Point(56, 156);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(398, 42);
            textSenha.TabIndex = 0;
            textSenha.Text = "SENHA";
            // 
            // textLogin
            // 
            textLogin.BackColor = Color.Red;
            textLogin.BorderStyle = BorderStyle.None;
            textLogin.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLogin.ForeColor = SystemColors.InactiveBorder;
            textLogin.Location = new Point(56, 82);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(398, 42);
            textLogin.TabIndex = 0;
            textLogin.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 104);
            label1.Name = "label1";
            label1.Size = new Size(418, 25);
            label1.TabIndex = 1;
            label1.Text = "__________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 183);
            label2.Name = "label2";
            label2.Size = new Size(418, 25);
            label2.TabIndex = 1;
            label2.Text = "__________________________________________________________";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textLogin;
        private TextBox textSenha;
        private Label label2;
        private Button btnEntrar;
        private Label label1;
        private Button btnFechar;
    }
}
