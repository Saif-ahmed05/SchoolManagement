using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using schoolmenagment.controller;
using schoolmenagment.models;

namespace schoolmenagment.View
{
    public partial class Exam : Form
    {
        private ExamController examController = new ExamController();
        private int selectedExamId = -1;


        public Exam()
        {
            InitializeComponent();
            LoadCourseComboBox();
            LoadExamData();
        }
        private void LoadCourseComboBox()
        {
            /*using (var conn = data.datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT CourseId, CourseName FROM Course";

                var dt = new DataTable();
                using (var da = new System.Data.SQLite.SQLiteDataAdapter(cmd))
                
                cmbsubject.DisplayMember = "CourseName";
                cmbsubject.ValueMember = "CourseId";
                cmbsubject.DataSource = dt;
            */
         }
        
        private void LoadSubjectComboBox()
        {
            try
            {
                var subjects = Coursecontroller.GetAll();
                cmbcourse.DisplayMember = "CourseName";
                cmbcourse.ValueMember = "CourseId";
                cmbcourse.DataSource = subjects;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }
        private void LoadExamData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = examController.GetAllExams();
        }

        private void cmbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtexamname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exam_Load(object sender, EventArgs e)
        {
            LoadSubjectComboBox();
            LoadExamData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtexamname.Text))
                {
                    MessageBox.Show("Please enter exam name.");
                    return;
                }

                if (cmbsubject.SelectedValue == null)
                {
                    MessageBox.Show("Please select a course.");
                    return;
                }

                var exam = new models.Exam
                {
                    ExamName = txtexamname.Text.Trim(),
                    CourseId = cmbsubject.SelectedValue.ToString() // Fix: Convert 'int' to 'string'  
                };

                examController.AddExam(exam);
                MessageBox.Show("Exam added successfully.");
                ClearInputs();
                LoadExamData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam: " + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            try
            {
                var exam = new models.Exam
                {
                    ExamId = selectedExamId,
                    ExamName = txtexamname.Text.Trim(),
                    CourseId = cmbcourse.SelectedValue.ToString() // Fix: Convert 'int' to 'string'  
                };

                examController.UpdateExam(exam);
                MessageBox.Show("Exam updated successfully.");
                ClearInputs();
                LoadExamData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating exam: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    examController.DeleteExam(selectedExamId);
                    MessageBox.Show("Exam deleted successfully.");
                    ClearInputs();
                    LoadExamData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting exam: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedExamId = Convert.ToInt32(row.Cells["ExamId"].Value);
                txtexamname.Text = row.Cells["ExamName"].Value.ToString();
                cmbsubject.SelectedValue = row.Cells["CourseId"].Value.ToString(); // Fix: Convert 'int' to 'string'  
            }
        }
        private void ClearInputs()
        {
            txtexamname.Clear();
            cmbsubject.SelectedIndex = 0;
            selectedExamId = -1;
        }
    }
}
