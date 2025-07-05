using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schoolmenagment.controller;
using schoolmenagment.models;

namespace schoolmenagment.View
{
    public partial class Markform : Form
    {

        private Markcontroller markController;
        private ExamController examController; // Assuming you have this
        private int selectedMarkId = -1;

        public Markform()
        {
            InitializeComponent();
            if (finder.usertype != "Admin")
            {
                btnadd.Visible = false;
                btndelete.Visible = false;
                btnedit.Visible = false;

                lblexam.Visible = false;
                lblscore.Visible = false;
                lblstudentid.Visible = false;

                txtscore.Visible = false;
                txtstudentid.Visible = false;
                cmbexam.Visible = false;


            }

            markController = new Markcontroller();
            examController = new ExamController();

        }

        private void LoadExamComboBox()
        {
            try
            {
                var exams = examController.GetAllExams(); // Returns List<Exam>
                cmbexam.DisplayMember = "ExamId";  // Or "Name" if your Exam model has one
                cmbexam.ValueMember = "ExamId";
                cmbexam.DataSource = exams;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exams: " + ex.Message);
            }
        }
        private void LoadMarkData()
        {
            dataGridView1.DataSource = markController.GetAllMarks()
                .Select(m => new
                {
                    m.MarkId,
                    m.StudentId,
                    m.ExamId,
                    m.Score
                }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Markform_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt32(row.Cells["MarkId"].Value);
                txtstudentid.Text = row.Cells["StudentId"].Value.ToString();
                cmbexam.SelectedValue = row.Cells["ExamId"].Value;
                txtscore.Text = row.Cells["Score"].Value.ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Mark mark = new Mark
                {
                    StudentId = int.Parse(txtstudentid.Text),
                    ExamId = Convert.ToInt32(cmbexam.SelectedValue),
                    Score = int.Parse(txtscore.Text)
                };
                markController.AddMark(mark);
                MessageBox.Show("Mark added successfully.");
                ClearInputs();
                LoadMarkData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding mark: " + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            try
            {
                Mark mark = new Mark
                {
                    MarkId = selectedMarkId,
                    StudentId = int.Parse(txtstudentid.Text),
                    ExamId = Convert.ToInt32(cmbexam.SelectedValue),
                    Score = int.Parse(txtscore.Text)
                };
                markController.UpdateMark(mark);
                MessageBox.Show("Mark updated successfully.");
                ClearInputs();
                LoadMarkData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating mark: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            try
            {
                markController.DeleteMark(selectedMarkId);
                MessageBox.Show("Mark deleted successfully.");
                ClearInputs();
                LoadMarkData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting mark: " + ex.Message);
            }
        }
        private void ClearInputs()
        {
            selectedMarkId = -1;
            txtstudentid.Clear();
            txtscore.Clear();
            if (cmbexam.Items.Count > 0)
                cmbexam.SelectedIndex = 0;
        }
    }
}
