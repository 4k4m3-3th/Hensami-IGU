namespace Presentacion
{
    partial class areaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(areaVenta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            codigoProducto = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            cantidadProducto = new DataGridViewTextBoxColumn();
            precioProducto = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(198, 208, 245);
            label1.Location = new Point(93, 33);
            label1.Name = "label1";
            label1.Size = new Size(143, 18);
            label1.TabIndex = 0;
            label1.Text = "Codigo Producto";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(98, 104, 128);
            textBox1.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(198, 208, 245);
            textBox1.Location = new Point(114, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 104, 128);
            button1.Font = new Font("Hack Nerd Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(198, 208, 245);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(532, 33);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar Producto";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(98, 104, 128);
            button2.Font = new Font("Hack Nerd Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(198, 208, 245);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(532, 62);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 3;
            button2.Text = "Agregar Producto";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(48, 52, 70);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 52, 70);
            dataGridViewCellStyle1.Font = new Font("FiraCode Nerd Font", 8.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(198, 208, 245);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(98, 104, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(198, 208, 245);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdVenta, codigoProducto, nombreProducto, cantidadProducto, precioProducto });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(98, 104, 128);
            dataGridView1.Location = new Point(72, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 52, 70);
            dataGridViewCellStyle2.Font = new Font("FiraCode Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(198, 208, 245);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(98, 104, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(198, 208, 245);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 52, 70);
            dataGridViewCellStyle3.Font = new Font("Hack Nerd Font", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(198, 208, 245);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(98, 104, 128);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(198, 208, 245);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 230);
            dataGridView1.TabIndex = 5;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "idVenta";
            IdVenta.Name = "IdVenta";
            IdVenta.Width = 80;
            // 
            // codigoProducto
            // 
            codigoProducto.HeaderText = "codigoProducto";
            codigoProducto.Name = "codigoProducto";
            codigoProducto.Width = 129;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "nombreProducto";
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Width = 129;
            // 
            // cantidadProducto
            // 
            cantidadProducto.HeaderText = "cantidadProducto";
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.Width = 143;
            // 
            // precioProducto
            // 
            precioProducto.HeaderText = "precioProducto";
            precioProducto.Name = "precioProducto";
            precioProducto.Width = 129;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(98, 104, 128);
            button4.Font = new Font("Hack Nerd Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(198, 208, 245);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(200, 327);
            button4.Name = "button4";
            button4.Size = new Size(115, 32);
            button4.TabIndex = 6;
            button4.Text = "Actualizar";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(98, 104, 128);
            button5.Font = new Font("Hack Nerd Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(198, 208, 245);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(333, 327);
            button5.Name = "button5";
            button5.Size = new Size(104, 32);
            button5.TabIndex = 7;
            button5.Text = "Eliminar";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(98, 104, 128);
            button6.Font = new Font("Hack Nerd Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(198, 208, 245);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(461, 327);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 8;
            button6.Text = "Pagar";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(98, 104, 128);
            button7.Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(198, 208, 245);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(713, 408);
            button7.Name = "button7";
            button7.Size = new Size(75, 30);
            button7.TabIndex = 9;
            button7.Text = "Salir";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(98, 104, 128);
            textBox2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(198, 208, 245);
            textBox2.Location = new Point(303, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(198, 208, 245);
            label2.Location = new Point(267, 33);
            label2.Name = "label2";
            label2.Size = new Size(161, 18);
            label2.TabIndex = 11;
            label2.Text = "Cantidad Producto";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(98, 104, 128);
            button3.Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(198, 208, 245);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 408);
            button3.Name = "button3";
            button3.Size = new Size(107, 30);
            button3.TabIndex = 12;
            button3.Text = "Regresar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // areaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 52, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "areaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "areaVenta";
            Load += areaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn codigoProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn cantidadProducto;
        private DataGridViewTextBoxColumn precioProducto;
    }
}