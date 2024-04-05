namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVista
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
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(186, 148);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(412, 33);
            textBox7.TabIndex = 112;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(186, 112);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(412, 30);
            textBox4.TabIndex = 111;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(64, 112);
            label9.Name = "label9";
            label9.Size = new Size(116, 27);
            label9.TabIndex = 109;
            label9.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 108;
            label3.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(212, 41);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 105;
            label1.Text = "Editar Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(596, 33);
            button1.Name = "button1";
            button1.Size = new Size(38, 35);
            button1.TabIndex = 104;
            button1.Text = "✓";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-1, 33);
            button2.Name = "button2";
            button2.Size = new Size(38, 35);
            button2.TabIndex = 103;
            button2.Text = "✕";
            button2.UseVisualStyleBackColor = false;
            // 
            // UsuarioEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 257);
            ControlBox = false;
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UsuarioEditarVista";
            StartPosition = FormStartPosition.CenterScreen;
            Load += UsuarioEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox7;
        private TextBox textBox4;
        private Label label9;
        private Label label3;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}