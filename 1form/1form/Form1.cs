using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = "Результат: ";
                int n = Convert.ToInt32(textBox1.Text);
                int k = Convert.ToInt32(textBox2.Text);
                result.Text +=($"\n {f(n) + f(2 * k)}");
            }
            catch (Exception)
            {
                result.Text += " Ошибка ввода, некорректное число";
                MessageBox.Show(
                     "Число имеет некорректное значение!",
                     "Предупреждение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button3);
            }
        }
        static double f(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + f(n - 1);
            }
        }
    }
}
