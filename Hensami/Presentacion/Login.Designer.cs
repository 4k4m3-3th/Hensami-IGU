namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btoLogin = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(350, 124);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(80, 18);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Hack Nerd Font", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(350, 213);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(80, 18);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(98, 104, 128);
            txtUser.Font = new Font("Hack Nerd Font", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(198, 208, 245);
            txtUser.Location = new Point(350, 145);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 26);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(98, 104, 128);
            txtPass.Font = new Font("Hack Nerd Font", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtPass.ForeColor = Color.FromArgb(198, 208, 245);
            txtPass.Location = new Point(350, 234);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 26);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btoLogin
            // 
            btoLogin.BackColor = Color.FromArgb(98, 104, 128);
            btoLogin.Font = new Font("FiraCode Nerd Font Ret", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btoLogin.Image = (Image)resources.GetObject("btoLogin.Image");
            btoLogin.ImageAlign = ContentAlignment.MiddleRight;
            btoLogin.Location = new Point(353, 284);
            btoLogin.Name = "btoLogin";
            btoLogin.Size = new Size(97, 29);
            btoLogin.TabIndex = 4;
            btoLogin.Text = "LOGIN";
            btoLogin.TextAlign = ContentAlignment.MiddleLeft;
            btoLogin.UseVisualStyleBackColor = false;
            btoLogin.Click += btoLogin_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("FiraCode Nerd Font", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 94);
            label1.TabIndex = 5;
            label1.Text = "HENSAMI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 104, 128);
            button1.Font = new Font("FiraCode Nerd Font", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(713, 411);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(279, 124);
            label2.Name = "label2";
            label2.Size = new Size(113, 75);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(312, 215);
            label3.Name = "label3";
            label3.Size = new Size(52, 66);
            label3.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 52, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btoLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(label2);
            Controls.Add(label3);
            ForeColor = Color.FromArgb(198, 208, 245);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btoLogin;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}