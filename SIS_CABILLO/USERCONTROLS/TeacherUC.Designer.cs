namespace SIS_CABILLO.FORMS
{
    partial class TeacherUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTeacher = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelAddTeacher = new Panel();
            txtSpecialization = new TextBox();
            txtDepartment = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpHireDate = new DateTimePicker();
            lblHireDate = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblAddNewTeacher = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            panelAddTeacher.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(30, 28);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.Size = new Size(697, 407);
            dgvTeacher.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(76, 455);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 51);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(316, 455);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 51);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(549, 455);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 51);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panelAddTeacher
            // 
            panelAddTeacher.BackColor = Color.Gray;
            panelAddTeacher.BorderStyle = BorderStyle.Fixed3D;
            panelAddTeacher.Controls.Add(txtSpecialization);
            panelAddTeacher.Controls.Add(txtDepartment);
            panelAddTeacher.Controls.Add(btnCancel);
            panelAddTeacher.Controls.Add(btnSave);
            panelAddTeacher.Controls.Add(cmbStatus);
            panelAddTeacher.Controls.Add(lblStatus);
            panelAddTeacher.Controls.Add(dtpHireDate);
            panelAddTeacher.Controls.Add(lblHireDate);
            panelAddTeacher.Controls.Add(txtPhone);
            panelAddTeacher.Controls.Add(txtEmail);
            panelAddTeacher.Controls.Add(txtLastName);
            panelAddTeacher.Controls.Add(txtFirstName);
            panelAddTeacher.Controls.Add(lblAddNewTeacher);
            panelAddTeacher.Location = new Point(441, 0);
            panelAddTeacher.Name = "panelAddTeacher";
            panelAddTeacher.Size = new Size(318, 529);
            panelAddTeacher.TabIndex = 5;
            panelAddTeacher.Visible = false;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(44, 337);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(228, 25);
            txtSpecialization.TabIndex = 17;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(44, 296);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(228, 25);
            txtDepartment.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(173, 458);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 49);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(44, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 49);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(135, 379);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(137, 25);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(44, 387);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(135, 254);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(137, 27);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = Color.Transparent;
            lblHireDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(44, 261);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(69, 17);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "HireDate:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(44, 210);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(228, 25);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(44, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(228, 25);
            txtEmail.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(44, 130);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(228, 25);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(44, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(228, 25);
            txtFirstName.TabIndex = 1;
            // 
            // lblAddNewTeacher
            // 
            lblAddNewTeacher.AutoSize = true;
            lblAddNewTeacher.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddNewTeacher.Location = new Point(83, 28);
            lblAddNewTeacher.Name = "lblAddNewTeacher";
            lblAddNewTeacher.Size = new Size(146, 19);
            lblAddNewTeacher.TabIndex = 0;
            lblAddNewTeacher.Text = "Add New Teacher";
            // 
            // TeacherUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panelAddTeacher);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvTeacher);
            Name = "TeacherUC";
            Size = new Size(759, 529);
            Load += TeacherUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            panelAddTeacher.ResumeLayout(false);
            panelAddTeacher.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTeacher;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelAddTeacher;
        private TextBox txtSpecialization;
        private TextBox txtDepartment;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private DateTimePicker dtpHireDate;
        private Label lblHireDate;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblAddNewTeacher;
    }
}
