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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void отпускBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.отпускBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.гПУDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гПУDataSet.Отпуск". При необходимости она может быть перемещена или удалена.
            this.отпускTableAdapter.Fill(this.гПУDataSet.Отпуск);

        }
    }
}
