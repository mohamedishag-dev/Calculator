using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double FirstNumber = 0;
        private string operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labScreen.Text = "";
            labResult.Text = "";
        }

        private void NumbersBTNsClick(Button btn)
        {
            labScreen.Text += btn.Tag.ToString();
            labResult.Text += btn.Tag.ToString();

        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            NumbersBTNsClick((Button)sender);

        }

        private void ArithmeticBTNsClick(Button btn)
        {

            if (labResult.Text != "")
            {
                if (labScreen.Text == "")
                {
                    labScreen.Text = labResult.Text;
                }
                FirstNumber = double.Parse(labResult.Text);
                operationPerformed = btn.Tag.ToString();
                labScreen.Text += " " + operationPerformed + " ";
                labResult.Text = "";

            }
        }

        private void ArithmeticOperators_Click(object sender, MouseEventArgs e)
        {
            ArithmeticBTNsClick((Button)sender);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            operationPerformed = "";
            labScreen.Text = "";
            labResult.Text = "";
            FirstNumber = 0;

        }

        private double Result()
        {

            if (operationPerformed == "+")
                return FirstNumber + double.Parse(labResult.Text);

            else if (operationPerformed == "-")
                return FirstNumber - double.Parse(labResult.Text);

            else if (operationPerformed == "*")
                return FirstNumber * double.Parse(labResult.Text);

            else
                if (double.Parse(labResult.Text) != 0)
                   return FirstNumber / double.Parse(labResult.Text);
            return 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            labScreen.Text = "";
            FirstNumber = Result();
            labResult.Text = FirstNumber.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (labResult.Text != "")
            {

                labScreen.Text += ".".ToString();
                labResult.Text += ".".ToString();

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
    

            if (labResult.Text.Length > 0)
            {
                labResult.Text = labResult.Text.Remove(labResult.Text.Length - 1, 1);
                labScreen.Text = labScreen.Text.Remove(labScreen.Text.Length - 1, 1);
            }

        }
    
    }
}
