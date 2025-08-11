namespace SIS_CABILLO
{
    partial class Student
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
            panelStudent = new Panel();
            btnLogout = new Button();
            lblWelcomeStudent = new Label();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.RoyalBlue;
            panelStudent.BorderStyle = BorderStyle.FixedSingle;
            panelStudent.Controls.Add(btnLogout);
            panelStudent.Controls.Add(lblWelcomeStudent);
            panelStudent.Location = new Point(1, 0);
            panelStudent.Margin = new Padding(3, 2, 3, 2);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(267, 416);
            panelStudent.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(35, 364);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(195, 38);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcomeStudent
            // 
            lblWelcomeStudent.AutoSize = true;
            lblWelcomeStudent.BackColor = Color.Transparent;
            lblWelcomeStudent.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.ForeColor = Color.White;
            lblWelcomeStudent.Location = new Point(68, 87);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(134, 16);
            lblWelcomeStudent.TabIndex = 0;
            lblWelcomeStudent.Text = "Welcome Student!";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(947, 415);
            Controls.Add(panelStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStudent;
        private Button btnLogout;
        private Label lblWelcomeStudent;
    }
}