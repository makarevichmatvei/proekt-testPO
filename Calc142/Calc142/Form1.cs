using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

        private void Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            double secondArg = Convert.ToDouble(TextIn2.Text);
            ITwoArgCalc calculator = CalculatorsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArg, secondArg);
            labelResult.Text = result.ToString();
        }
        private void OneClick(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(TextIn1.Text);
            IOneArgCalc calculator = OneCalculatorsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArg);
            labelResult.Text = result.ToString();
        }

    }
}
