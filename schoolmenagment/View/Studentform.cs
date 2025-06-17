using schoolmenagment.controller;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmenagment.View
{
    public partial class Studentform : Form
    {
        private Studentcontroller controller = new Studentcontroller();
        private int selectedStudentId = -1;

        public Studentform()
        {
            InitializeComponent();
            LoadGenderOptions();
            LoadStudents();
        }
        private void LoadGenderOptions()
        {
            cmbgender.Items.Clear();
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");
            cmbgender.Items.Add("Other");
            cmbgender.SelectedIndex = 0;
        }
        private void LoadStudents()
        {
            dgvstudent.DataSource = controller.GetAllStudents();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Name = txtstudentname.Text,
                Address = txtaddress.Text,
                Age = int.TryParse(txtage.Text, out int age) ? age : 0,
                Gender = cmbgender.SelectedItem.ToString()
            };

            controller.AddStudent(student);
            MessageBox.Show("Student added successfully!");
            ClearForm();
            LoadStudents();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to edit.");
                return;
            }

            Student student = new Student
            {
                StudentId = selectedStudentId,
                Name = txtstudentname.Text,
                Address = txtaddress.Text,
                Age = int.TryParse(txtage.Text, out int age) ? age : 0,
                Gender = cmbgender.SelectedItem.ToString()
            };

            controller.UpdateStudent(student);
            MessageBox.Show("Student updated successfully!");
            ClearForm();
            LoadStudents();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            // ✅ Show Yes/No confirmation dialog
            var result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                controller.DeleteStudent(selectedStudentId);
                MessageBox.Show("Student deleted successfully!");
                ClearForm();
                LoadStudents();
            }
            else
            {
                // Optional: do nothing or show message
                MessageBox.Show("Delete cancelled.");
            }
        }

        private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvstudent.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    selectedStudentId = Convert.ToInt32(row.Cells[0].Value); // Column 0 = StudentID
                    txtstudentname.Text = row.Cells[1].Value.ToString(); // Name
                    txtage.Text = row.Cells[2].Value.ToString(); // Age
                    txtaddress.Text = row.Cells[3].Value.ToString(); // Address (if needed)
                    cmbgender.SelectedItem = row.Cells[4].Value.ToString(); // Gender
                    MessageBox.Show("Selected Student ID = " + selectedStudentId); // ✅ debug
                }
            }

        }
        private void ClearForm()
        {
            txtstudentname.Clear();
            txtaddress.Clear();
            txtage.Clear();
            cmbgender.SelectedIndex = 0;
            selectedStudentId = -1;
        }
    }
}
