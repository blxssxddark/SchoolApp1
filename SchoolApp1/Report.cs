using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
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
using DocumentFormat.OpenXml.Wordprocessing;
using FastReport;

namespace SchoolApp1
{
    public partial class Report : Form
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
        public void ExportToWord(string filePath)
        {
            try
            {
                // Создание документа Word
                using (WordprocessingDocument doc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    // Создание основного тела документа
                    MainDocumentPart mainPart = doc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Получение данных из базы данных (пример)
                    DataTable dataTable = GetEquipmentDataFromDatabase();

                    // Добавление данных в документ
                    Table table = new Table();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        TableRow tableRow = new TableRow();
                        foreach (object cellValue in row.ItemArray)
                        {
                            TableCell tableCell = new TableCell();
                            tableCell.Append(new Paragraph(new Run(new Text(cellValue.ToString()))));
                            tableRow.Append(tableCell);
                        }
                        table.Append(tableRow);
                    }
                    body.Append(table);
                }

                Console.WriteLine("Данные успешно экспортированы в файл Word.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при экспорте данных в файл Word: " + ex.Message);
            }
        }

        // Пример метода для получения данных из базы данных
        private DataTable GetEquipmentDataFromDatabase()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Equipment";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание экземпляра класса WordExporter
            WordExporter wordExporter = new WordExporter();

            // Вызов метода экспорта данных в файл Word
            wordExporter.ExportToWord("C://SchoolApp1/отчет.docx"); // Замените "отчет.docx" на путь к файлу, в который вы хотите сохранить отчет
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DateTime startDate = new DateTime(2020, 1, 1);
            DateTime endDate = new DateTime(2024, 12, 31);
            string outputPath = "C://SchoolApp1/отчет1.docx.docx";

            RepairCostAnalysisReport reportGenerator = new RepairCostAnalysisReport();
            reportGenerator.GenerateReport(startDate, endDate, outputPath);

        }
    }
}

