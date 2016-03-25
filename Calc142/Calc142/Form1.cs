using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            double secondArg = Convert.ToDouble(TextIn2.Text);
            double result = firstArg + secondArg;
            labelResult.Text = result.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            double secondArg = Convert.ToDouble(TextIn2.Text);
            double result = firstArg - secondArg;
            labelResult.Text = result.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            double secondArg = Convert.ToDouble(TextIn2.Text);
            double result = firstArg * secondArg;
            labelResult.Text = result.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            double secondArg = Convert.ToDouble(TextIn2.Text);
            double result = firstArg / secondArg;
            labelResult.Text = result.ToString();
        }

    }
}
