namespace SIS_CABILLO
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            panelLogin = new Panel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLoginNow = new Label();
            lblWelcomeSIS = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-66, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblLoginNow);
            panelLogin.Controls.Add(lblWelcomeSIS);
            panelLogin.Location = new Point(645, 46);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(388, 462);
            panelLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(115, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 67);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(60, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password:";
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(60, 187);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username:";
            txtUsername.Size = new Size(267, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblLoginNow
            // 
            lblLoginNow.AutoSize = true;
            lblLoginNow.BackColor = Color.Transparent;
            lblLoginNow.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginNow.ForeColor = Color.Black;
            lblLoginNow.Location = new Point(115, 106);
            lblLoginNow.Name = "lblLoginNow";
            lblLoginNow.Size = new Size(150, 32);
            lblLoginNow.TabIndex = 1;
            lblLoginNow.Text = "Login now!";
            // 
            // lblWelcomeSIS
            // 
            lblWelcomeSIS.AutoSize = true;
            lblWelcomeSIS.BackColor = Color.Transparent;
            lblWelcomeSIS.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeSIS.ForeColor = Color.RoyalBlue;
            lblWelcomeSIS.Location = new Point(35, 47);
            lblWelcomeSIS.Name = "lblWelcomeSIS";
            lblWelcomeSIS.Size = new Size(313, 48);
            lblWelcomeSIS.TabIndex = 0;
            lblWelcomeSIS.Text = "Welcome to SIS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1082, 553);
            Controls.Add(panelLogin);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLogin;
        private Label lblWelcomeSIS;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblLoginNow;
    }
}
