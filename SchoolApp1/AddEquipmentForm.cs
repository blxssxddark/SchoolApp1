using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp1
{
    public partial class AddEquipmentForm : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";
        //private Form2 form;
        public AddEquipmentForm()
        {
            InitializeComponent();
            //form = new Form2(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Создаем SQL команду для выполнения запроса INSERT
                    string query = "INSERT INTO Equipment (Model, SerialNumber, PurchaseDate, AdditionalInfo) VALUES (@Model, @SerialNumber, @PurchaseDate, @Description)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Добавляем параметры к команде
                    command.Parameters.AddWithValue("@Model", textBoxModel.Text);
                    command.Parameters.AddWithValue("@SerialNumber", textBoxSerialNumber.Text);
                    command.Parameters.AddWithValue("@PurchaseDate", dateTimePickerPurchaseDate.Value);
                    //command.Parameters.AddWithValue("@EquipmentType", comboBoxEquipmentType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Description", textBoxDescription.Text);

                    // Выполняем запрос INSERT
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " запись(ей) добавлена(ы) в базу данных.");

                    // Закрываем соединение
                    connection.Close();
                    // Возвращение результата диалога как DialogResult.OK
                    this.DialogResult = DialogResult.OK;
                }
                

                // Закрываем форму после успешного добавления записи
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи в базу данных: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Закрываем форму при нажатии кнопки "Отмена"
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
