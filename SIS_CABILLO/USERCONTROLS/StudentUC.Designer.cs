namespace SIS_CABILLO.FORMS
{
    partial class StudentUC
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
            dgvStudent = new DataGridView();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelAddStudent = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollDate = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            cmbGender = new ComboBox();
            lblGender = new Label();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblAddNewStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            panelAddStudent.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(25, 22);
            dgvStudent.Margin = new Padding(3, 2, 3, 2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(610, 305);
            dgvStudent.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(66, 344);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(115, 38);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(280, 344);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(483, 344);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelAddStudent
            // 
            panelAddStudent.BackColor = Color.Gray;
            panelAddStudent.BorderStyle = BorderStyle.Fixed3D;
            panelAddStudent.Controls.Add(btnCancel);
            panelAddStudent.Controls.Add(btnSave);
            panelAddStudent.Controls.Add(cmbStatus);
            panelAddStudent.Controls.Add(lblStatus);
            panelAddStudent.Controls.Add(dtpEnrollDate);
            panelAddStudent.Controls.Add(lblEnrollDate);
            panelAddStudent.Controls.Add(txtAddress);
            panelAddStudent.Controls.Add(txtPhone);
            panelAddStudent.Controls.Add(txtEmail);
            panelAddStudent.Controls.Add(cmbGender);
            panelAddStudent.Controls.Add(lblGender);
            panelAddStudent.Controls.Add(dtpDOB);
            panelAddStudent.Controls.Add(lblDOB);
            panelAddStudent.Controls.Add(txtLastName);
            panelAddStudent.Controls.Add(txtFirstName);
            panelAddStudent.Controls.Add(lblAddNewStudent);
            panelAddStudent.Location = new Point(385, 0);
            panelAddStudent.Margin = new Padding(3, 2, 3, 2);
            panelAddStudent.Name = "panelAddStudent";
            panelAddStudent.Size = new Size(279, 398);
            panelAddStudent.TabIndex = 4;
            panelAddStudent.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(151, 344);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 37);
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
            btnSave.Location = new Point(38, 344);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 37);
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
            cmbStatus.Location = new Point(118, 304);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(120, 23);
            cmbStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(38, 310);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(118, 272);
            dtpEnrollDate.Margin = new Padding(3, 2, 3, 2);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(120, 23);
            dtpEnrollDate.TabIndex = 11;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.BackColor = Color.Transparent;
            lblEnrollDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(38, 278);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(68, 15);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "EnrollDate:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(38, 238);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(200, 21);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(38, 207);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(200, 21);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(38, 177);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(200, 21);
            txtEmail.TabIndex = 7;
            // 
            // cmbGender
            // 
            cmbGender.FlatStyle = FlatStyle.Popup;
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(118, 147);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(120, 23);
            cmbGender.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(38, 151);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender:";
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(118, 114);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(120, 23);
            dtpDOB.TabIndex = 4;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(38, 119);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(71, 15);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "DateofBirth:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(38, 86);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "LastName:";
            txtLastName.Size = new Size(200, 21);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(38, 56);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "FirstName:";
            txtFirstName.Size = new Size(200, 21);
            txtFirstName.TabIndex = 1;
            // 
            // lblAddNewStudent
            // 
            lblAddNewStudent.AutoSize = true;
            lblAddNewStudent.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddNewStudent.Location = new Point(73, 21);
            lblAddNewStudent.Name = "lblAddNewStudent";
            lblAddNewStudent.Size = new Size(127, 16);
            lblAddNewStudent.TabIndex = 0;
            lblAddNewStudent.Text = "Add New Student";
            // 
            // StudentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panelAddStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(dgvStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentUC";
            Size = new Size(664, 397);
            Load += StudentUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            panelAddStudent.ResumeLayout(false);
            panelAddStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudent;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelAddStudent;
        private Label lblAddNewStudent;
        private Label lblDOB;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblEnrollDate;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private ComboBox cmbGender;
        private Label lblGender;
        private DateTimePicker dtpDOB;
        private Button btnSave;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private DateTimePicker dtpEnrollDate;
        private Button btnCancel;
    }
}
