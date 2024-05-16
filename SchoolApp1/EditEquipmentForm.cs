using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp1
{
    public partial class EditEquipmentForm : Form
    {

        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";

        // Добавляем поля для хранения параметров оборудования
        // Поля для хранения данных
        private int equipmentID;
        private string model;
        private string serialNumber;
        private DateTime purchaseDate;
       // private string equipmentType;
        private string description;
        public EditEquipmentForm(int equipmentID, string model, string serialNumber, DateTime purchaseDate, string description)
        {
            InitializeComponent();
            this.equipmentID = equipmentID;
            this.model = model;
            this.serialNumber = serialNumber;
            this.purchaseDate = purchaseDate;
          //  this.equipmentType = equipmentType;
            this.description = description;

            // Заполнение элементов управления данными
            textBoxModel.Text = model;
            textBoxSerialNumber.Text = serialNumber;
            dateTimePickerPurchaseDate.Value = purchaseDate;
           // comboBoxEquipmentType.Text = equipmentType;
           textBoxDescription.Text = description;
        }

        private void EditEquipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Подключение к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Подготовка SQL-запроса для обновления данных
                    string query = "UPDATE Equipment SET Model = @Model, SerialNumber = @SerialNumber, PurchaseDate = @PurchaseDate," +
                        "AdditionalInfo = @Description WHERE EquipmentID = @EquipmentID";


                    // Создание команды для выполнения SQL-запроса
                    SqlCommand command = new SqlCommand(query, connection);

                    // Передача параметров SQL-запроса из свойств формы
                    command.Parameters.AddWithValue("@Model", textBoxModel.Text);
                    command.Parameters.AddWithValue("@SerialNumber", textBoxSerialNumber.Text);
                    command.Parameters.AddWithValue("@PurchaseDate", dateTimePickerPurchaseDate.Value);
                    //command.Parameters.AddWithValue("@EquipmentType", comboBoxEquipmentType.Text);
                    command.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                    command.Parameters.AddWithValue("@EquipmentID", equipmentID); // Используем идентификатор оборудования из свойства формы

                    // Выполнение SQL-запроса
                    command.ExecuteNonQuery();

                    // Возвращение результата диалога как DialogResult.OK
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
