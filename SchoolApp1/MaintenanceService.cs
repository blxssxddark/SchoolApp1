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
    public partial class MaintenanceService : Form
    {
        //private MaintenanceService maintenanceService = new MaintenanceService();

        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";

        public MaintenanceService()
        {
            InitializeComponent();
            PopulateRepairTypeComboBox();
        }

        private void PopulateRepairTypeComboBox()
        {
            // Очистите список перед добавлением значений
            comboBoxRepairType.Items.Clear();

            // Добавьте значения в список
            comboBoxRepairType.Items.Add("Техническое обслуживание");
            comboBoxRepairType.Items.Add("Ремонт");
            comboBoxRepairType.Items.Add("Замена расходных материалов");
            // Добавьте другие значения по мере необходимости
        }

        /*public void AddMaintenance(string serialNumber, DateTime repairDate, string repairType, decimal cost, string description)
        {
            try
            {
                // Создание подключения к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открытие подключения
                    connection.Open();

                    // Получение ID оборудования по его серийному номеру
                    string queryGetEquipmentID = "SELECT EquipmentID FROM Equipment WHERE SerialNumber = @SerialNumber";

                    // Создание команды для получения ID оборудования
                    using (SqlCommand commandGetEquipmentID = new SqlCommand(queryGetEquipmentID, connection))
                    {
                        commandGetEquipmentID.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        int equipmentID = (int)commandGetEquipmentID.ExecuteScalar();

                        // Создание SQL-запроса INSERT
                        string query = "INSERT INTO Repairs (EquipmentID, RepairDate, RepairType, Cost, Description) VALUES (@EquipmentID, @RepairDate, @RepairType, @Cost, @Description)";

                        // Создание команды для выполнения SQL-запроса
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Передача параметров запроса
                            command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                            command.Parameters.AddWithValue("@RepairDate", repairDate);
                            command.Parameters.AddWithValue("@RepairType", repairType);
                            command.Parameters.AddWithValue("@Cost", cost);
                            command.Parameters.AddWithValue("@Description", description);

                            // Выполнение SQL-запроса
                            command.ExecuteNonQuery();

                            Console.WriteLine("Новое обслуживание успешно добавлено.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении обслуживания: " + ex.Message);
            }
        }*/

        public void AddMaintenance(string serialNumber, DateTime repairDate, string repairType, decimal cost, string description)
        {
            try
            {
               

                // Создание подключения к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открытие подключения
                    connection.Open();

                    // Получение ID оборудования по его серийному номеру
                    string queryGetEquipmentID = "SELECT EquipmentID FROM Equipment WHERE SerialNumber = @SerialNumber";

                    // Создание команды для получения ID оборудования
                    using (SqlCommand commandGetEquipmentID = new SqlCommand(queryGetEquipmentID, connection))
                    {
                        commandGetEquipmentID.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        object result = commandGetEquipmentID.ExecuteScalar();

                        // Проверка, найден ли оборудование
                        if (result == null)
                        {
                            // Если оборудование не найдено, выводим сообщение об ошибке и прерываем выполнение операции
                            MessageBox.Show("Оборудование с указанным серийным номером не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }

                        int equipmentID = (int)result;

                        // Создание SQL-запроса INSERT
                        string query = "INSERT INTO Repairs (EquipmentID, RepairDate, RepairType, Cost, Description) VALUES (@EquipmentID, @RepairDate, @RepairType, @Cost, @Description)";

                        // Создание команды для выполнения SQL-запроса
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Передача параметров запроса
                            command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                            command.Parameters.AddWithValue("@RepairDate", repairDate);
                            command.Parameters.AddWithValue("@RepairType", repairType);
                            command.Parameters.AddWithValue("@Cost", cost);
                            command.Parameters.AddWithValue("@Description", description);

                            // Выполнение SQL-запроса
                            command.ExecuteNonQuery();

                            MessageBox.Show("Новое обслуживание успешно добавлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении обслуживания: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*            // Получение значений из контролов формы
            string serialNumber = textBoxSerialNumber.Text; // Получаем серийный номер оборудования
            DateTime repairDate = dateTimePickerRepairDate.Value;
            //string repairType = comboBoxRepairType.Text;
            string repairType = comboBoxRepairType.SelectedItem.ToString();
            decimal cost = Convert.ToDecimal(textBoxCost.Text);
            string description = textBoxDescription.Text;

            // Добавление обслуживания с использованием серийного номера оборудования
            AddMaintenance(serialNumber, repairDate, repairType, cost, description);*/

            // Получение значений из контролов формы
            string serialNumber = textBoxSerialNumber.Text; // Получаем серийный номер оборудования

            // Проверка наличия серийного номера
            if (string.IsNullOrEmpty(serialNumber))
            {
                MessageBox.Show("Введите серийный номер оборудования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прекращаем выполнение метода
            }

            // Продолжаем только если серийный номер не пустой
            DateTime repairDate = dateTimePickerRepairDate.Value;
            string repairType = comboBoxRepairType.SelectedItem?.ToString(); // Проверяем, что выбран элемент в комбобоксе
            if (string.IsNullOrEmpty(repairType))
            {
                MessageBox.Show("Выберите тип обслуживания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прекращаем выполнение метода
            }

            // Преобразование введенного значения в число с использованием TryParse
            if (!decimal.TryParse(textBoxCost.Text, out decimal cost))
            {
                MessageBox.Show("Неверный формат стоимости обслуживания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прекращаем выполнение метода
            }

            string description = textBoxDescription.Text;

            // Добавление обслуживания с использованием серийного номера оборудования
            AddMaintenance(serialNumber, repairDate, repairType, cost, description);


        }

        private void MaintenanceService_Load(object sender, EventArgs e)
        {

        }
    }
}
