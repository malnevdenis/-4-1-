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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void дата_трудоустройстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дата_трудоустройстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Дата_трудоустройства". При необходимости она может быть перемещена или удалена.
            this.дата_трудоустройстваTableAdapter.Fill(this.гПУDataSet.Дата_трудоустройства);

        }
    }
}
