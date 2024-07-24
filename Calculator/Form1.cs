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
        private TextBox selectedTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 1. convert 'string' to 'int'
            if (txtNumber1.Text == "" || txtNumber2.Text == "")
            {
                lblResult.Text = "enter number";
                return;
            }
            float num1 = float.Parse(txtNumber1.Text);
            float num2 = float.Parse(txtNumber2.Text);
            // 2. Validate inputs


            // - Chek me have values


            if (cmbOperater.Text == "+")
            {
                lblResult.Text = (num1 + num2).ToString();
            }
            else if (cmbOperater.Text == "-")
            {
                lblResult.Text = (num1 - num2).ToString();
            }
            else if (cmbOperater.Text == "*")
            {
                lblResult.Text = (num1 * num2).ToString();
            }
            else if (cmbOperater.Text == "/")
            {
                // - Check that txtNumber2 is not 0
                if (num2 == 0)
                {
                    return;
                }
                lblResult.Text = (num1 / num2).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cmbOperater.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            cmbOperater.Text = "-";
        }

        private void btnDual_Click(object sender, EventArgs e)
        {
            cmbOperater.Text = "*";
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            cmbOperater.Text = "/";
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void btn_Click_global(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }

        private void btnNkuda_Click(object sender, EventArgs e)
        {
            if (selectedTextBox.Text.Contains("."))
            {
                return;
            }
            selectedTextBox.Text += ".";
        }
    }
}
