namespace SIS_CABILLO
{
    partial class Teacher
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
            panelTeacher = new Panel();
            btnLogout = new Button();
            lblWelcomeTeacher = new Label();
            panelTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // panelTeacher
            // 
            panelTeacher.BackColor = Color.RoyalBlue;
            panelTeacher.BorderStyle = BorderStyle.FixedSingle;
            panelTeacher.Controls.Add(btnLogout);
            panelTeacher.Controls.Add(lblWelcomeTeacher);
            panelTeacher.Location = new Point(0, 0);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(305, 554);
            panelTeacher.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(40, 485);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(223, 50);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.BackColor = Color.Transparent;
            lblWelcomeTeacher.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.ForeColor = Color.White;
            lblWelcomeTeacher.Location = new Point(78, 116);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(154, 19);
            lblWelcomeTeacher.TabIndex = 0;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1082, 553);
            Controls.Add(panelTeacher);
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            panelTeacher.ResumeLayout(false);
            panelTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTeacher;
        private Button btnLogout;
        private Label lblWelcomeTeacher;
    }
}