namespace SistemasVentas.VISTA.VendedorVistas
{
    partial class InformacionRapidaVista
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
            button4 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(122, 27);
            label1.Name = "label1";
            label1.Size = new Size(311, 27);
            label1.TabIndex = 5;
            label1.Text = "Información del Cliente";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(11, 19, 46);
            button4.DialogResult = DialogResult.OK;
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(319, 221);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(141, 36);
            button4.TabIndex = 17;
            button4.Text = "Continuar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(11, 19, 46);
            button3.DialogResult = DialogResult.Cancel;
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(116, 221);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(104, 36);
            button3.TabIndex = 16;
            button3.Text = "Atrás";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(162, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 34);
            textBox2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 87);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 18;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(162, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 34);
            textBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 20;
            label2.Text = "Apellido:";
            // 
            // InformacionRapidaVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 284);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "InformacionRapidaVista";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
    }
}