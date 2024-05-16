using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SchoolApp1
{
    public class RepairCostAnalysisReport
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=C:\SchoolApp1\SchoolApp1\SchoolApp.mdf;Integrated Security=True";


        public void GenerateReport(DateTime startDate, DateTime endDate, string outputPath)
        {
            try
            {
                // Создание документа Word
                using (WordprocessingDocument doc = WordprocessingDocument.Create(outputPath, WordprocessingDocumentType.Document))
                {
                    // Создание главного объекта Document и Body в документе
                    MainDocumentPart mainPart = doc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    Paragraph paragraph = new Paragraph();
                    Run run = new Run(new Text("Анализ затрат на ремонт и обслуживание оборудования"));
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

                    // Добавление периода времени
                    Paragraph period = body.AppendChild(new Paragraph());
                    Run periodRun = period.AppendChild(new Run());
                    periodRun.AppendChild(new Text($"Период: с {startDate.ToShortDateString()} по {endDate.ToShortDateString()}"));

                    // Получение данных из базы данных
                    DataTable repairData = GetRepairDataFromDatabase(startDate, endDate);

                    // Добавление таблицы с данными
                    Table table = CreateTable(repairData);
                    body.Append(table);

                    // Добавление итоговой суммы
                Paragraph total = body.AppendChild(new Paragraph());
                    Run totalRun = total.AppendChild(new Run());
                    totalRun.AppendChild(new Text($"Итоговая сумма: {GetTotalCost(repairData)}"));



                    // Сохранение документа
                    doc.MainDocumentPart.Document.Save();
                }

            
                MessageBox.Show("Данные успешно экспортированы в файл Word.", "Генерация отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета:" + ex.Message, "Генерация отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
            }
        }

        // Метод для получения данных о ремонтах из базы данных за определенный период времени
        private DataTable GetRepairDataFromDatabase(DateTime startDate, DateTime endDate)
        {
            DataTable repairData = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT RepairDate, RepairType, Cost FROM Repairs WHERE RepairDate BETWEEN @StartDate AND @EndDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(repairData);
            }
            return repairData;
        }

        // Метод для создания таблицы с данными о ремонтах
        private Table CreateTable(DataTable repairData)
        {
            Table table = new Table();

            // Создание заголовков таблицы
            TableRow headerRow = new TableRow();
            headerRow.Append(CreateTableCell("Дата ремонта"));
            headerRow.Append(CreateTableCell("Тип ремонта"));
            headerRow.Append(CreateTableCell("Затраты"));
            table.Append(headerRow);

            // Заполнение данными из DataTable
            foreach (DataRow row in repairData.Rows)
            {
                TableRow dataRow = new TableRow();
                dataRow.Append(CreateTableCell(row["RepairDate"].ToString()));
                dataRow.Append(CreateTableCell(row["RepairType"].ToString()));
                dataRow.Append(CreateTableCell(row["Cost"].ToString()));
                table.Append(dataRow);
            }

            return table;
        }

        // Метод для создания ячейки таблицы
        private TableCell CreateTableCell(string text)
        {
            TableCell cell = new TableCell();
            cell.Append(new Paragraph(new Run(new Text(text))));
            return cell;
        }
        // Метод для вычисления итоговой суммы затрат на ремонт и обслуживание
        private decimal GetTotalCost(DataTable repairData)
        {
            decimal totalCost = 0;
            foreach (DataRow row in repairData.Rows)
            {
                totalCost += Convert.ToDecimal(row["Cost"]);
            }
            return totalCost;
        }
    }
}
