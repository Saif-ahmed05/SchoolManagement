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
           
            Courseform form = new Courseform();
            form.Show();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
           
            Studentform form = new Studentform();
            form.Show();



        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnexams_Click(object sender, EventArgs e)
        {
         
            Exam exam = new Exam();
            exam.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void btnmarks_Click(object sender, EventArgs e)
        {
           
            Markform markForm = new Markform();
            markForm.Show();
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            
            Timetableform form = new Timetableform();
            form.Show();

        }

        private void btnroom_Click(object sender, EventArgs e)
        {
           
            Roomform form = new Roomform();
            form.Show();
        }

        private void btnlecture_Click(object sender, EventArgs e)
        {
            
            Lectureform form = new Lectureform();
            form.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            
            Userform form = new Userform();
            form.Show();
        }
    }
}
