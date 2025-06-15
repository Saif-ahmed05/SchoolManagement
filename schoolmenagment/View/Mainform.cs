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

        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Studentform studentform = new Studentform();
            
                
            studentform.Show();
        }
    }
}
