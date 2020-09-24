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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="123" && textBox2.Text == "123")
            {
                Form10 f10 = new Form10();
                f10.Show();
                this.Hide();
            }
            else
                MessageBox.Show(
           "Не верные логин или пароль\nПопробуйте ввести данные еще раз",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);

            //Form1 f1 = new Form1();
            //f1.Show();
            //Form2 f2 = new Form2();
            //f2.Show();
            //Form3 f3 = new Form3();
            //f3.Show();
            //Form4 f4 = new Form4();
            //f4.Show();
            //Form5 f5 = new Form5();
            //f5.Show();
            //Form6 f6 = new Form6();
            //f6.Show();
            //Form7 f7 = new Form7();
            //f7.Show();
            //Form8 f8 = new Form8();
            //f8.Show();
        }
    }
}
