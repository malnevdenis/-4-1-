﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void больничныйBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.больничныйBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Больничный". При необходимости она может быть перемещена или удалена.
            this.больничныйTableAdapter.Fill(this.гПУDataSet.Больничный);

        }

        private void больничныйDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
