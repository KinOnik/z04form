using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2form
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
                result.Text = ("Результат:\n\t");
                int A = Convert.ToInt32(textBox1.Text);
                int B = Convert.ToInt32(textBox2.Text);
                for (int i = A; i <= B; i++)
                {
                    result.Text+=("\n\t");
                    f(i);
                }

            }
            catch (Exception)
            {
                result.Text+=( "Введено некорректное число");
                MessageBox.Show(
                     "Число имеет некорректное значение!",
                     "Предупреждение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button3);
            }

        }

        void f(int n)
        {
            if (n != 0)
            {
                f(n / 10);
            }
            else return;
            result.Text +=(n % 10 + " ");
        }
    }
}
