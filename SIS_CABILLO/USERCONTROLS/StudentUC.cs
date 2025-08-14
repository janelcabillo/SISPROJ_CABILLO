using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SIS_CABILLO.FORMS
{
    public partial class StudentUC : UserControl
    {
        private bool isUpdateMode = false;
        private int selectedStudentId = -1;
        public StudentUC()
        {
            InitializeComponent();
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.connectionString))
            {
                string query = "SELECT * From Student Order by student_id desc";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudent.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            dtpEnrollDate.Value = DateTime.Today;
        }

        private void StudentUC_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!panelAddStudent.Visible)
            {
                panelAddStudent.Visible = true;
                panelAddStudent.BringToFront();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation before saving
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }
            if (cmbGender.SelectedItem == null || string.IsNullOrWhiteSpace(cmbGender.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select the Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter the Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter the Phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter the Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (cmbStatus.SelectedItem == null || string.IsNullOrWhiteSpace(cmbStatus.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select the Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return;
            }
            using (SqlConnection connection = new SqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();

                if (isUpdateMode && selectedStudentId > 0)
                {
                    // UPDATE existing student
                    string updateQuery = @"UPDATE student SET  
                                    first_name = @first_name,
                                    last_name = @last_name,
                                    date_of_birth = @dob,
                                    gender = @gender,
                                    email = @email,
                                    phone = @phone,
                                    address = @address,
                                    enrollment_date = @enroll,
                                    status = @status
                                   WHERE student_id = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@enroll", dtpEnrollDate.Value.Date);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@id", selectedStudentId);

                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Student updated successfully!" : "Update failed. Student not found.");
                    }
                }
                else
                {
                    // 1. Insert into user_login & get new user_id
                    string insertUserQuery = @"INSERT INTO user_login(username, password_hash, role_id) 
                                       VALUES (@username, @password_hash, @role_id); 
                                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newUserId;
                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, connection))
                    {
                        cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@role_id", 2); // Student role

                        newUserId = (int)cmdUser.ExecuteScalar();
                    }

                    // 2. Insert into student (student_id will be auto-generated by DB)
                    string insertStudentQuery = @"INSERT INTO student 
                                          (first_name, last_name, date_of_birth, gender, email, phone, address, enrollment_date, status, user_id) 
                                          VALUES (@first_name, @last_name, @dob, @gender, @email, @phone, @address, @enrollment, @status, @user_id)";

                    using (SqlCommand cmdStudent = new SqlCommand(insertStudentQuery, connection))
                    {
                        cmdStudent.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmdStudent.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@enrollment", dtpEnrollDate.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "");
                        cmdStudent.Parameters.AddWithValue("@user_id", newUserId);

                        cmdStudent.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Reset form
                ClearFields();
                panelAddStudent.Visible = false;
                isUpdateMode = false;
                selectedStudentId = -1;

                // Reload the data
                LoadStudents();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAddStudent.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            dtpEnrollDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                // 1. Get selected student's ID
                selectedStudentId = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["student_id"].Value);

                // 2. Load data into form fields
                txtFirstName.Text = dgvStudent.SelectedRows[0].Cells["first_name"].Value.ToString();
                txtLastName.Text = dgvStudent.SelectedRows[0].Cells["last_name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["date_of_birth"].Value);
                cmbGender.SelectedItem = dgvStudent.SelectedRows[0].Cells["gender"].Value.ToString();
                txtEmail.Text = dgvStudent.SelectedRows[0].Cells["email"].Value.ToString();
                txtPhone.Text = dgvStudent.SelectedRows[0].Cells["phone"].Value.ToString();
                txtAddress.Text = dgvStudent.SelectedRows[0].Cells["address"].Value.ToString();
                dtpEnrollDate.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["enrollment_date"].Value);
                cmbStatus.SelectedItem = dgvStudent.SelectedRows[0].Cells["status"].Value.ToString();

                // 3. Enable update mode
                isUpdateMode = true;

                // 4. Show the panel
                panelAddStudent.Visible = true;
                panelAddStudent.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
