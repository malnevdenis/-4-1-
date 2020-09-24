using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void отпускныеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отпускныеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Отпускные". При необходимости она может быть перемещена или удалена.
            this.отпускныеTableAdapter.Fill(this.гПУDataSet.Отпускные);

        }

        private void отпускныеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
