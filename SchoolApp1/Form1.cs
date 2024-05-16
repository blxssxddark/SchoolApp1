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
            // Создание новой формы
           RepairsForm newForm = new RepairsForm();

            // Отображение новой формы
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            // Создание новой формы
            Report newForm = new Report();

            // Отображение новой формы
            newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            Form2 newForm = new Form2();

            // Отображение новой формы
            newForm.Show();
        }
    }
}
