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
    public partial class Lectureform : Form
    {
        private Lecturecontroller controller = new Lecturecontroller();
        private int selectedLectureId = -1;

        public Lectureform()
        {
            InitializeComponent();
            if (finder.usertype != "Admin")
            {
                btnadd.Visible = false;
                btndelete.Visible = false;
                btnedit.Visible = false;

                lbladress.Visible = false;
                lblage.Visible = false;
                lblname.Visible = false;

                txtadress.Visible = false;
                txtage.Visible = false;
                txtname.Visible = false;

            }

            LoadLectures();
        }
        private void LoadLectures()
        {
            dgvlecture.DataSource = controller.GetAllLectures();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Lecture lecture = new Lecture
            {
                Name = txtname.Text,
                Age = txtage.Text,
                Adress = txtadress.Text
            };

            controller.AddLecture(lecture);
            MessageBox.Show("Lecture added successfully!");
            ClearForm();
            LoadLectures();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedLectureId == -1)
            {
                MessageBox.Show("Please select a lecture to update.");
                return;
            }

            Lecture lecture = new Lecture
            {
                LectureID = selectedLectureId,
                Name = txtname.Text,
                Age = txtage.Text,
                Adress = txtadress.Text
            };

            controller.UpdateLecture(lecture);
            MessageBox.Show("Lecture updated successfully!");
            ClearForm();
            LoadLectures();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedLectureId == -1)
            {
                MessageBox.Show("Please select a lecture to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this lecture?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.DeleteLecture(selectedLectureId);
                MessageBox.Show("Lecture deleted successfully!");
                ClearForm();
                LoadLectures();
            }
        }

        private void dgvlecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvlecture.Rows[e.RowIndex];
                selectedLectureId = Convert.ToInt32(row.Cells["LectureID"].Value);
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                txtadress.Text = row.Cells["Adress"].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtname.Clear();
            txtage.Clear();
            txtadress.Clear();
            selectedLectureId = -1;
        }
    }
}
