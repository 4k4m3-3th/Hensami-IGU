namespace Presentacion
{
    partial class areaInversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areaInversion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("FiraCode Nerd Font", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 42);
            label1.Name = "label1";
            label1.Size = new Size(208, 29);
            label1.TabIndex = 0;
            label1.Text = "BALANCE SALDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(360, 162);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Inversion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(360, 225);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Gastos";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 104, 128);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(360, 308);
            button1.Name = "button1";
            button1.Size = new Size(126, 26);
            button1.TabIndex = 3;
            button1.Text = "CALCULAR";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(98, 104, 128);
            textBox1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(198, 208, 245);
            textBox1.Location = new Point(360, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(98, 104, 128);
            textBox2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(198, 208, 245);
            textBox2.Location = new Point(360, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 25);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(98, 104, 128);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(21, 415);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 6;
            button2.Text = "Regresar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(98, 104, 128);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(711, 415);
            button3.Name = "button3";
            button3.Size = new Size(77, 23);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(335, 171);
            label4.Name = "label4";
            label4.Size = new Size(26, 44);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(335, 244);
            label5.Name = "label5";
            label5.Size = new Size(26, 24);
            label5.TabIndex = 9;
            // 
            // areaInversion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 52, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(198, 208, 245);
            Name = "areaInversion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "areaInversion";
            Load += areaInversion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
    }
}