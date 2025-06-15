using schoolmenagment.controller;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace schoolmenagment
{
    public partial class Studentform : Form
    {
        private Studentcontroller controller;
        private int selectedStudentId = -1;
        public Studentform()
        {
            InitializeComponent();
            InitializeComponent();
            controller = new Studentcontroller();
            LoadStudents();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblstudent.Text) || string.IsNullOrWhiteSpace(lbladdress.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            Student student = new Student
            {
                Name = lblstudent.Text,
                Address = lbladdress.Text
            };

            controller.AddStudent(student);
            MessageBox.Show("Student Added Successfully");
            LoadStudents();
        }

        private void dgvstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvstudents.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(row.Cells["Id"].Value);
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                cmbgender.Text = row.Cells["Gender"].Value.ToString();
                cmbcoures.SelectedValue = row.Cells["CourseId"].Value;
            }
        }

        private void cmbcoures_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Studentform_Load(object sender, EventArgs e)
        {

            LoadCourses();
            LoadStudents();
        }

        private void LoadStudents()
        {
            List<Student> students = controller.GetAllStudents();
            dgvstudents.DataSource = students;
            dgvstudents.ClearSelection();
            ClearInputs();
            selectedStudentId = -1;
        }
        private void ClearInputs()
        {
            lblstudent.Text = "";
            lbladdress.Text = "";
        }
        private void LoadCourses()
        {
            
            
            var courses = Coursecontroller.GetAllCourses();
            cmbcoures.DataSource = courses;
            cmbcoures.DisplayMember = "CourseId";
            cmbcoures.ValueMember = "CourseName";
            

        }
        private void ClearForm()
        {
            txtname.Text = "";
            txtage.Text = "";
            cmbgender.SelectedIndex = -1;
            cmbcoures.SelectedIndex = -1;
            selectedStudentId = -1;
        }


        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                controller.DeleteStudent(selectedStudentId);
                MessageBox.Show("Student Deleted Successfully");
                LoadStudents();
            }
        }

        private void btneditstudent_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lblstudent.Text) || string.IsNullOrWhiteSpace(lbladdress.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            Student student = new Student
            {
                Id = selectedStudentId,
                Name = lblstudent.Text,
                Address = lbladdress.Text
            };

            controller.UpdateStudent(student);
            MessageBox.Show("Student Updated Successfully");
            LoadStudents();
        }
    }
}


