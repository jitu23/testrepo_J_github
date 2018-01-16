using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckEmptyEntry(textBox1.Text) && CheckEmptyEntry(textBox2.Text))
            {
                if (CheckNumber(textBox1.Text) && CheckNumber(textBox2.Text))
                    MessageBox.Show(AddNumber(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString());
                else MessageBox.Show("Check entry");
            }
            else MessageBox.Show("Check entry");
        }
        public bool CheckEmptyEntry(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            else return true;
        }
        public bool CheckNumber(string value)
        {
            double result;
            if (double.TryParse(value, out result))
                return true;
            else return false;
        }
        public int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}
