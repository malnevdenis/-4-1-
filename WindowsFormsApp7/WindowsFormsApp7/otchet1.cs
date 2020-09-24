using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp7
{
    public partial class otchet1 : Form
    {
        public otchet1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=USER-ПК\USER1; Initial Catalog=ГПУ; Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"Select o.дата_начала_отпуска, o.дата_окончания_отпуска, oe.отпускные_сумма 
                from Сотрудники as s
                join Отпуск as o on s.код_сотрудника = o.код_сотрудника
                join Отпускные as oe on o.Код_отпуска = oe.код_отпуска
                join Информация_о_сотруднике as inf on s.код_сотрудника = inf.код_сотрудника
                where s.код_сотрудника = " + textBox1.Text, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Введенного НОМЕРА сотрудника не существует\nПроверте НОМЕР в списке");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelApp.Visible = true;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            ExcelApp.Columns[1].ColumnWidth = 25;
            ExcelApp.Columns[2].ColumnWidth = 25;
            ExcelApp.Columns[3].ColumnWidth = 15;

            string connectionString = @"Data Source=USER-ПК\USER1; Initial Catalog=ГПУ; Integrated Security=True";
            int row = dataGridView1.RowCount + 8 + 3;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }

            ExcelApp.Range _excelCells1 = (ExcelApp.Range)ExcelWorkSheet.get_Range("A1", "D1").Cells;
            _excelCells1.Merge(Type.Missing);
            _excelCells1.Value = "Отчет об отпускных";
            _excelCells1.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            _excelCells1.Font.Size = 16;
        
            ExcelApp.Range _excelCells2 = (ExcelApp.Range)ExcelWorkSheet.get_Range("A3", "D3").Cells;
            _excelCells2.Merge(Type.Missing);
            _excelCells2.Value = "От кого получены бланки________________________";
            _excelCells2.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            _excelCells2.Font.Size = 16;

            ExcelApp.Range _excelCells3 = (ExcelApp.Range)ExcelWorkSheet.get_Range("B4", "E4").Cells;
            _excelCells3.Merge(Type.Missing);
            _excelCells3.Value = "Наименование организации     ГПУ";
            _excelCells3.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            _excelCells3.Font.Size = 16;

            ExcelApp.Range _excelCells4 = (ExcelApp.Range)ExcelWorkSheet.get_Range("A5", "D5").Cells;
            _excelCells4.Merge(Type.Missing);
            _excelCells4.Value = "Кому выданы бланки________________________";
            _excelCells4.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            _excelCells4.Font.Size = 16;

            ExcelApp.Range _excelCells5 = (ExcelApp.Range)ExcelWorkSheet.get_Range("B7", "E7").Cells;
            _excelCells5.Merge(Type.Missing);
            _excelCells5.Value = "Наименование организации     ГПУ";
            _excelCells5.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            _excelCells5.Font.Size = 16;

            

            for (int i = 1; i < dataGridView1.RowCount + 3; i++)
            {
                (ExcelWorkSheet.Cells[8, i] as ExcelApp.Range).Font.Bold = true;
                (ExcelWorkSheet.Cells[8, i] as ExcelApp.Range).Borders.LineStyle = true;
            }

            ExcelApp.Cells[8, 1] = "Дата начала отпуска";
            ExcelApp.Cells[8, 2] = "Дата окончания отпуска";
            ExcelApp.Cells[8, 3] = "Опускная сумма";

            ExcelApp.Cells[17, 1] = "ФИО сотрудника        "+textBox1.Text;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    (ExcelWorkSheet.Cells[i + 8, j + 1] as ExcelApp.Range).Borders.LineStyle = true;
                    ExcelApp.Cells[i + 9, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
                //(ExcelWorkSheet.Cells[i + 8, 4] as ExcelApp.Range).Borders.LineStyle = true;
            }
        }
    }
}
