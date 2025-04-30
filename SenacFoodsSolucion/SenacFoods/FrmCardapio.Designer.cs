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
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(344, 208);
            btn.Name = "btn";
            btn.Size = new Size(112, 34);
            btn.TabIndex = 1;
            btn.Text = "Cardapio";
            btn.UseVisualStyleBackColor = true;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Name = "FrmCardapio";
            Text = "FrmCardapio";
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
    }
}