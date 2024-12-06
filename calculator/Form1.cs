using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = result.ToString();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void M_P_Click(object sender, EventArgs e)
        {
            // x += int.Parse(textBox1.Text);
            result += 1;
            textBox1.Text = result.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            result = int.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation =but0.Text ; 
            result = double .Parse(textBox1.Text);
            isoperation = true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation = but0.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation = but0.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation = but0.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation = but0.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            operation = but0.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text=(result + double.Parse(textBox1.Text)).ToString(); break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString(); break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString(); break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString(); break;

                case "%":
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString(); break;


              //  case "^":
              //      textBox1.Text = (result ^ double.Parse(textBox1.Text)).ToString(); break;


            }
        }

        private void _0_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if(textBox1.Text=="0" || isoperation==true)
            { textBox1.Clear(); }
            if(but0.Text==".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;

        }

        private void _1_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;

        }

        private void _2_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _3_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _4_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _5_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _6_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _7_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _8_Click(object sender, EventArgs e)
        { 
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void _9_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }
            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }

        private void point_Click(object sender, EventArgs e)
        {
            Button but0 = (Button)sender;
            if (textBox1.Text == "0" || isoperation == true)
            { textBox1.Clear(); }

            if (but0.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but0.Text; ; }
            }
            else
            {
                textBox1.Text = textBox1.Text + but0.Text;
            }
            isoperation = false;
        }
    }
}
