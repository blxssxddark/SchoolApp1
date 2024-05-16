using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace SchoolApp1
{
    public partial class RepairsForm : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";

        public RepairsForm()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        private void RepairsForm_Load(object sender, EventArgs e)
        {
            LoadRepairsData();
            // Установка авторазмеров для всех столбцов
            foreach (DataGridViewColumn column in dataGridViewRepairs.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // или другой режим авторазмера по вашему выбору
            }
        }

        private void LoadRepairsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT r.RepairID, r.RepairDate, r.RepairType, e.Model," +
                    " e.SerialNumber, r.Cost, r.Description " +
                    " FROM  Repairs r JOIN Equipment e ON " +
                    "r.EquipmentID = e.EquipmentID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewRepairs.DataSource = dataTable;
            }
        }

        private void dataGridViewRepairs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceService newForm = new MaintenanceService();
            // newForm.Show();
            newForm.ShowDialog();
            // Если пользователь сохраняет изменения, обновляем данные в таблице
            if (newForm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }
        public void UpdateDataGridView(DataTable dataTable)
        {
            dataGridViewRepairs.DataSource = dataTable;
        }

        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT r.RepairID, r.RepairDate, r.RepairType, e.Model," +
                   " e.SerialNumber, r.Cost, r.Description " +
                   " FROM  Repairs r JOIN Equipment e ON " +
                   "r.EquipmentID = e.EquipmentID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                UpdateDataGridView(dataTable);
            }
        }
    }
}
