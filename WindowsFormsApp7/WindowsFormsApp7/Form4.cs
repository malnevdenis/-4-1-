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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void окладBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.окладBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter.Fill(this.гПУDataSet.Оклад);

        }
    }
}
