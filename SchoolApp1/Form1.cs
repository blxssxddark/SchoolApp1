using System.Configuration;

namespace SchoolApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �������� ����� �����
           RepairsForm newForm = new RepairsForm();

            // ����������� ����� �����
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            // �������� ����� �����
            Report newForm = new Report();

            // ����������� ����� �����
            newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ����� �����
            Form2 newForm = new Form2();

            // ����������� ����� �����
            newForm.Show();
        }
    }
}
