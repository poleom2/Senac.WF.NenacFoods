namespace SenacFoods
{
    partial class FormPrincipal
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
            btnUsuario = new Button();
            btnPedidoozinha = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            lblMensagem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnPedidoozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(29, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(883, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(255, 128, 255);
            btnUsuario.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.Black;
            btnUsuario.Location = new Point(648, 56);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(149, 122);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedidoozinha
            // 
            btnPedidoozinha.BackColor = Color.FromArgb(0, 192, 192);
            btnPedidoozinha.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btnPedidoozinha.FlatAppearance.BorderSize = 0;
            btnPedidoozinha.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidoozinha.ForeColor = Color.Black;
            btnPedidoozinha.Location = new Point(451, 56);
            btnPedidoozinha.Name = "btnPedidoozinha";
            btnPedidoozinha.Size = new Size(149, 122);
            btnPedidoozinha.TabIndex = 0;
            btnPedidoozinha.Text = "Pedido\r\nCozinha";
            btnPedidoozinha.UseVisualStyleBackColor = false;
            btnPedidoozinha.Click += button3_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.FromArgb(128, 255, 128);
            btnComanda.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(254, 56);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(149, 122);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Yellow;
            btnCardapio.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btnCardapio.FlatAppearance.BorderSize = 0;
            btnCardapio.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardapio.ForeColor = Color.Black;
            btnCardapio.Location = new Point(56, 56);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(149, 122);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 13F);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(932, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(39, 43);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 20F);
            btnMinimizar.ForeColor = SystemColors.ActiveCaptionText;
            btnMinimizar.Location = new Point(889, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 52);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "-";
            btnMinimizar.TextAlign = ContentAlignment.TopCenter;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Arial", 14F);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(385, 43);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(180, 32);
            lblMensagem.TabIndex = 2;
            lblMensagem.Text = "lblMensagem";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(974, 416);
            Controls.Add(lblMensagem);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnComanda;
        private Button btnCardapio;
        private Button btnUsuario;
        private Button btnPedidoozinha;
        private Button btnFechar;
        private Button btnMinimizar;
        private Label lblMensagem;
    }
}