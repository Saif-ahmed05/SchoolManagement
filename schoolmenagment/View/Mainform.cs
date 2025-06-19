using schoolmenagment.models;
using schoolmenagment.View;

namespace schoolmenagment
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Courseform form = new Courseform();
            form.Show();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            this.Close();
            Studentform form = new Studentform();
            form.Show();



        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnexams_Click(object sender, EventArgs e)
        {
            this.Close();
            Exam exam = new Exam();
            exam.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            this.Close();

            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnmarks_Click(object sender, EventArgs e)
        {
            this.Close();
            Markform markForm = new Markform();
            markForm.Show();
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            this.Close();
            Timetableform form = new Timetableform();
            form.Show();

        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            this.Close();
            Roomform form = new Roomform();
            form.Show();
        }

        private void btnlecture_Click(object sender, EventArgs e)
        {
            this.Close();
            Lectureform form = new Lectureform();
            form.Show();
        }
    }
}
