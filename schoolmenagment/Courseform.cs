using schoolmenagment.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmenagment
{
    public partial class Courseform : Form

    {
        private Coursecontroller controller;
        private int selectedCourseId = -1;
        public Courseform()
        {
            InitializeComponent();
            controller = new Coursecontroller();
            LoadCourses();
        }

        private void Courseform_Load(object sender, EventArgs e)
        {
            LoadCourses();
            AddActionButtons();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string courseName = txtcourse.Text.Trim();

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please enter a course name.");
                return;
            }

            //Coursecontroller cc = new Coursecontroller();
            Coursecontroller.AddCourse(courseName);
            MessageBox.Show("Course added successfully!");
            txtcourse.Clear();
            LoadCourses();
        }

        private void txtcourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            string newName = txtcourse.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            Coursecontroller.UpdateCourse(selectedCourseId, newName);
            MessageBox.Show("Course updated.");
            selectedCourseId = -1;
            txtcourse.Clear();
            LoadCourses();
        }

        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // DELETE
                if (e.ColumnIndex == dgvcourse.Columns["Delete"].Index)
                {
                    int courseId = Convert.ToInt32(dgvcourse.Rows[e.RowIndex].Cells["Id"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this course?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Coursecontroller.DeleteCourse(courseId);
                        MessageBox.Show("Course deleted.");
                        LoadCourses();
                    }
                }
                // UPDATE (fill textbox)
                else if (e.ColumnIndex == dgvcourse.Columns["Update"].Index)
                {
                    selectedCourseId = Convert.ToInt32(dgvcourse.Rows[e.RowIndex].Cells["Id"].Value);
                    txtcourse.Text = dgvcourse.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }
            }
        }
        private void LoadCourses()
        {
            dgvcourse.DataSource = null;
            dgvcourse.DataSource = Coursecontroller.GetAllCourses();
        }
        private void AddActionButtons()
        {
            if (!dgvcourse.Columns.Contains("Update"))
            {
                DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
                updateButton.HeaderText = "Update";
                updateButton.Name = "Update";
                updateButton.Text = "Update";
                updateButton.UseColumnTextForButtonValue = true;
                dgvcourse.Columns.Add(updateButton);
            }

            if (!dgvcourse.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "Delete";
                deleteButton.Name = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dgvcourse.Columns.Add(deleteButton);
            }
        }

        private void btndlt_Click(object sender, EventArgs e)
        {

        }
    }
}
