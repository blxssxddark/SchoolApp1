using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;

namespace SchoolApp1
{
    public class WordExporter
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";


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

                    // Добавление заголовка
                    // Создание абзаца с текстом
                    Paragraph paragraph = new Paragraph();
                    Run run = new Run(new Text("Отчет о текущем состоянии компьютерного оборудования"));
                    paragraph.Append(run);

                    // Применение форматирования к тексту
                    RunProperties runProperties = new RunProperties();
                    Bold bold = new Bold(); // Жирный шрифт
                    Italic italic = new Italic(); // Курсив
                    Underline underline = new Underline() { Val = UnderlineValues.Single }; // Подчеркивание
                    FontSize fontSize = new FontSize() { Val = "24" }; // Размер шрифта
                                                                       //Color color = new Color() { Val = "FF0000" }; // Цвет шрифта (красный)
                    ParagraphProperties paragraphProperties = new ParagraphProperties();
                    Justification justification = new Justification() { Val = JustificationValues.Center };

                    paragraphProperties.Append(justification);
                    paragraph.ParagraphProperties = paragraphProperties;

                    runProperties.Append(bold);
                    runProperties.Append(italic);
                    runProperties.Append(underline);
                    runProperties.Append(fontSize);
                    //runProperties.Append(color);

                    run.RunProperties = runProperties;

                    // Добавление абзаца с форматированным текстом в документ
                    body.Append(paragraph);
                  
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

               
                MessageBox.Show("Данные успешно экспортированы в файл Word.", "Генерация отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета:" + ex.Message, "Генерация отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
