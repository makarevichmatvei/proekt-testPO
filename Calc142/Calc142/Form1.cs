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
            double result;
            switch (((Button) sender).Name)
            {
                case "plus":
                    result = firstArg + secondArg;
                    break;
                case "minus":
                    result = firstArg - secondArg;
                    break;
                case "multiply":
                    result = firstArg * secondArg;
                    break;
                case "divide":
                    result = firstArg / secondArg;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            labelResult.Text = result.ToString();
        }
    }
}
