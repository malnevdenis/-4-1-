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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void информация_о_сотрудникеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.информация_о_сотрудникеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.гПУDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Информация_о_сотруднике". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникеTableAdapter.Fill(this.гПУDataSet.Информация_о_сотруднике);

        }

        private void информация_о_сотрудникеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
