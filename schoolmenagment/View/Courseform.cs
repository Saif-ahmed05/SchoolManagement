using schoolmenagment.controller;
using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmenagment
{
    public partial class Courseform : Form

    {


        int selectedCourseId = -1;
        public Courseform()
        {
            InitializeComponent();
           
            if (finder.usertype != "Admin")
            {
                btnadd.Visible = false;
                btndelete.Visible = false;
                btnedit.Visible = false;

                lblCourse.Visible = false;
                txtcourse.Visible = false;
            }
            

            

            LoadCourses();
        }

        private void Courseform_Load(object sender, EventArgs e)
        {
            LoadCourses();

        }
        private void ClearInputs()
        {
            txtcourse.Text = "";
            selectedCourseId = -1;
           
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcourse.Text))
            {
                Coursecontroller.Add(txtcourse.Text);
                LoadCourses();
            }
        }

        private void txtcourse_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    if (selectedCourseId == -1)
        //    {
        //        MessageBox.Show("Please select a course to update.");
        //        return;
        //    }

        //    string newName = txtcourse.Text.Trim();

        //    if (string.IsNullOrEmpty(newName))
        //    {
        //        MessageBox.Show("Course name cannot be empty.");
        //        return;
        //    }

        //    Coursecontroller.UpdateCourse(selectedCourseId, newName);
        //    MessageBox.Show("Course updated.");
        //    selectedCourseId = -1;
        //    txtcourse.Clear();
        //    LoadCourses();
        //}

        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvcourse.Rows[e.RowIndex];

                if (row.Cells["CourseId"].Value != null)
                {
                    selectedCourseId = Convert.ToInt32(row.Cells["CourseId"].Value);
                    txtcourse.Text = row.Cells["CourseName"].Value.ToString();

                    // Debug
                    // MessageBox.Show("Selected ID: " + selectedCourseId);
                }
            }
        }
        private void LoadCourses()
        {
            dgvcourse.DataSource = null;
            dgvcourse.DataSource = Coursecontroller.GetAll();

            dgvcourse.Columns["CourseId"].Visible = false; // Hide ID column
            dgvcourse.Columns["CourseName"].HeaderText = "Course Name";

            txtcourse.Text = "";
            selectedCourseId = -1;
        }
        //private void AddActionButtons()
        //{
        //    if (!dgvcourse.Columns.Contains("Update"))
        //    {
        //        DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
        //        updateButton.HeaderText = "Update";
        //        updateButton.Name = "Update";
        //        updateButton.Text = "Update";
        //        updateButton.UseColumnTextForButtonValue = true;
        //        dgvcourse.Columns.Add(updateButton);
        //    }

        //    if (!dgvcourse.Columns.Contains("Delete"))
        //    {
        //        DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
        //        deleteButton.HeaderText = "Delete";
        //        deleteButton.Name = "Delete";
        //        deleteButton.Text = "Delete";
        //        deleteButton.UseColumnTextForButtonValue = true;
        //        dgvcourse.Columns.Add(deleteButton);
        //    }
        //}



        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this course?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Coursecontroller.Delete(selectedCourseId);
                    LoadCourses();
                    MessageBox.Show("Course deleted!");
                }
            }
            else
            {
                MessageBox.Show("Select a course to delete.");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedCourseId != -1 && !string.IsNullOrWhiteSpace(txtcourse.Text))
            {
                Coursecontroller.Update(selectedCourseId, txtcourse.Text);
                LoadCourses();
                MessageBox.Show("Course updated!");
            }
            else
            {
                MessageBox.Show("Select a course to edit.");
            }
        }
    }
}
