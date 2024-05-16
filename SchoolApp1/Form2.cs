using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;
using System.Security.Policy;

namespace SchoolApp1
{
    public partial class Form2 : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";

        
        public Form2()
        {
            InitializeComponent();
            // this.mainForm = mainForm;
            LoadEquipmentData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadEquipmentData();
            // Установка авторазмеров для всех столбцов
            foreach (DataGridViewColumn column in dataGridViewEquipment.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // или другой режим авторазмера по вашему выбору
            }
        }

        private void LoadEquipmentData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewEquipment.DataSource = dataTable;
            }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment WHERE Model LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBoxSearch.Text + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewEquipment.DataSource = dataTable;
            }
        }
        public void UpdateDataGridView(DataTable dataTable)
        {
            dataGridViewEquipment.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment WHERE Model LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBoxSearch.Text + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewEquipment.DataSource = dataTable;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEquipmentForm newForm = new AddEquipmentForm();
            // newForm.Show();
            newForm.ShowDialog();
            // Если пользователь сохраняет изменения, обновляем данные в таблице
            if (newForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.CurrentRow != null) // Проверяем, что выбрана хотя бы одна строка
            {
                DataGridViewRow currentRow = dataGridViewEquipment.CurrentRow;
                int equipmentID = Convert.ToInt32(currentRow.Cells["EquipmentID"].Value); // Предполагается, что имя столбца с идентификатором оборудования - "EquipmentID"

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteEquipment(equipmentID);
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void DeleteEquipment(int equipmentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Equipment WHERE EquipmentID = @EquipmentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EquipmentID", equipmentID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
            }
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                UpdateDataGridView(dataTable);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipment.CurrentRow != null) // Проверяем, что выбрана хотя бы одна строка
            {
                DataGridViewRow currentRow = dataGridViewEquipment.CurrentRow;
                int equipmentID = Convert.ToInt32(currentRow.Cells["EquipmentID"].Value); // Предполагается, что имя столбца с идентификатором оборудования - "EquipmentID"

                // Получаем данные выбранной строки
                string model = Convert.ToString(currentRow.Cells["Model"].Value);
                string serialNumber = Convert.ToString(currentRow.Cells["SerialNumber"].Value);
                DateTime purchaseDate = Convert.ToDateTime(currentRow.Cells["PurchaseDate"].Value);
                // string equipmentType = Convert.ToString(currentRow.Cells["EquipmentType"].Value);
                string description = Convert.ToString(currentRow.Cells["AdditionalInfo"].Value);

                // Создаем форму редактирования
                EditEquipmentForm editForm = new EditEquipmentForm(equipmentID, model, serialNumber, purchaseDate, description);

                // Устанавливаем свойства формы
                /*editForm.EquipmentID = equipmentID;
                editForm.Model = model;
                editForm.SerialNumber = serialNumber;
                editForm.PurchaseDate = purchaseDate;
                //editForm.EquipmentType = equipmentType;
                editForm.Description = description;*/

                editForm.ShowDialog();

                // Если пользователь сохраняет изменения, обновляем данные в таблице
                if (editForm.DialogResult == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
