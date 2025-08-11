namespace SIS_CABILLO
{
    partial class Admin
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
            panelAdmin = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnLogs = new Button();
            btnSubject = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            btnDashboard = new Button();
            lblWelcomeAdmin = new Label();
            panelContainer = new Panel();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.RoyalBlue;
            panelAdmin.BorderStyle = BorderStyle.FixedSingle;
            panelAdmin.Controls.Add(btnLogout);
            panelAdmin.Controls.Add(btnReports);
            panelAdmin.Controls.Add(btnLogs);
            panelAdmin.Controls.Add(btnSubject);
            panelAdmin.Controls.Add(btnTeacher);
            panelAdmin.Controls.Add(btnStudent);
            panelAdmin.Controls.Add(btnDashboard);
            panelAdmin.Controls.Add(lblWelcomeAdmin);
            panelAdmin.Location = new Point(0, 0);
            panelAdmin.Margin = new Padding(3, 2, 3, 2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(267, 416);
            panelAdmin.TabIndex = 0;
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
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.FlatStyle = FlatStyle.Popup;
            btnReports.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(35, 322);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(195, 38);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = Color.Transparent;
            btnLogs.FlatStyle = FlatStyle.Popup;
            btnLogs.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.ForeColor = Color.White;
            btnLogs.Location = new Point(35, 280);
            btnLogs.Margin = new Padding(3, 2, 3, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(195, 38);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = false;
            // 
            // btnSubject
            // 
            btnSubject.BackColor = Color.Transparent;
            btnSubject.FlatStyle = FlatStyle.Popup;
            btnSubject.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubject.ForeColor = Color.White;
            btnSubject.Location = new Point(35, 238);
            btnSubject.Margin = new Padding(3, 2, 3, 2);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(195, 38);
            btnSubject.TabIndex = 4;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = false;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.Transparent;
            btnTeacher.FlatStyle = FlatStyle.Popup;
            btnTeacher.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeacher.ForeColor = Color.White;
            btnTeacher.Location = new Point(35, 196);
            btnTeacher.Margin = new Padding(3, 2, 3, 2);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(195, 38);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.FlatStyle = FlatStyle.Popup;
            btnStudent.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.White;
            btnStudent.Location = new Point(35, 154);
            btnStudent.Margin = new Padding(3, 2, 3, 2);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(195, 38);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(35, 112);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(195, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.BackColor = Color.Transparent;
            lblWelcomeAdmin.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.ForeColor = Color.White;
            lblWelcomeAdmin.Location = new Point(68, 87);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(121, 16);
            lblWelcomeAdmin.TabIndex = 0;
            lblWelcomeAdmin.Text = "Welcome Admin!";
            // 
            // panelContainer
            // 
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelContainer.Location = new Point(272, 9);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(665, 398);
            panelContainer.TabIndex = 1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(947, 415);
            Controls.Add(panelContainer);
            Controls.Add(panelAdmin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdmin;
        private Label lblWelcomeAdmin;
        private Button btnLogout;
        private Button btnReports;
        private Button btnLogs;
        private Button btnSubject;
        private Button btnTeacher;
        private Button btnStudent;
        private Button btnDashboard;
        private Panel panelContainer;
    }
}