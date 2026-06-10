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
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labScreen.Text = "";
            labResult.Text = "0";
        }

        private void NumbersBTNsClick(Button btn)
        {
            labScreen.Text += btn.Tag.ToString();
            if (labResult.Text == "0")
            {
                labResult.Text = btn.Tag.ToString();

            }
            else
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
                operation = btn.Tag.ToString();
                labScreen.Text += " " + operation + " ";
                labResult.Text = "";

            }
        }

        private void ArithmeticOperators_Click(object sender, MouseEventArgs e)
        {
            ArithmeticBTNsClick((Button)sender);

        }

        private void ClaerScreen_Click(object sender, EventArgs e)
        {
            operation = "";
            labScreen.Text = "";
            labResult.Text = "0";
            FirstNumber = 0;

        }

        private double Calcaulator()
        {
            switch(operation)
            {
                case "+":
                    return FirstNumber + double.Parse(labResult.Text);
                    break;
                case "-":
                    return FirstNumber - double.Parse(labResult.Text);
                    break;
                case "*":
                    return FirstNumber * double.Parse(labResult.Text);
                    break;
                case "/":
                    if (double.Parse(labResult.Text) > 0)
                        return FirstNumber / double.Parse(labResult.Text); 
                    break;

                default:
                    return FirstNumber + double.Parse(labResult.Text);

            }

            return 0;
        }

        private void GetFirstNumber(object sender, EventArgs e)
        {

            labScreen.Text = "";
            FirstNumber = Calcaulator();
            labResult.Text = FirstNumber.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (labResult.Text != "0" &&labResult.Text != "" && !labResult.Text.Contains(".")) 
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

        private void button20_Click(object sender, EventArgs e)
        {

            // if (labResult.Text.Contains("(")) labResult.Text += ")";
            // // else if (labResult.Text.Contains(")")) labResult.Text += ")";
            //else labResult.Text += "(";

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }
    }
}