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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void отделыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отделыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.гПУDataSet.Отделы);

        }
    }
}
