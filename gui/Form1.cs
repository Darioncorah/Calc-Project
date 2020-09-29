using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnum0_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "0";
        }

        private void btnnum1_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "1";
        }

        private void btnnum2_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "2";
        }

        private void btnnum3_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "3";
        }

        private void btnnum4_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "4";
        }

        private void btnnum5_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "5";
        }

        private void btnnum6_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "6";
        }

        private void btnnum7_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "7";
        }

        private void btnnum8_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "8";
        }

        private void btnnum9_Click(object sender, EventArgs e)
        {
            txtcalc.Text += "9";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtcalc.Text += " + ";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            txtcalc.Text += " - ";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            txtcalc.Text += " * ";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            txtcalc.Text += " / ";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            Calc cal = new Calc();
            string[] calc = txtcalc.Text.Split(' ');
            //some basic Format checking
            if(calc.Length > 3 || calc.Length < 3 || calc.Contains(""))
            {
                MessageBox.Show("incorrect formatting");
            }
            else
            {
                switch (calc[1])
                {
                    case "+":
                        txtcalc.Text = calc[0] + " + " + calc[2] + " = " + cal.Add(Convert.ToDouble(calc[0]), Convert.ToDouble(calc[2]));
                        break;
                    case "-":
                        txtcalc.Text = calc[0] + " - " + calc[2] + " = " + cal.Sub(Convert.ToDouble(calc[0]), Convert.ToDouble(calc[2]));
                        break;
                    case "*":
                        txtcalc.Text = calc[0] + " * " + calc[2] + " = " + cal.Mult(Convert.ToDouble(calc[0]), Convert.ToDouble(calc[2]));
                        break;
                    case "/":
                        txtcalc.Text = calc[0] + " / " + calc[2] + " = " + cal.Div(Convert.ToDouble(calc[0]), Convert.ToDouble(calc[2]));
                        break;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcalc.Text = "";
        }

        private void btndec2hex_Click(object sender, EventArgs e)
        {
            Calc cal = new Calc();
            txtcalc.Text = cal.Dec2Hex(Convert.ToInt32(txtcalc.Text)).ToString();
        }

        private void btnhex2dec_Click(object sender, EventArgs e)
        {
            Calc cal = new Calc();
            txtcalc.Text = cal.Hex2Dec(txtcalc.Text).ToString();
        }
    }
}
