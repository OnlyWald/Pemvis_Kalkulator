using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Fix
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String ope = " ";
        bool press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Numb(object sender, EventArgs e)
        {
            if((Visual.Text == "0")||(press))
                Visual.Clear();
            press = false;
            Button a = (Button)sender;
            Visual.Text = Visual.Text + a.Text;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Aritamatika(object sender, EventArgs e)
        {
            Button Operator = (Button)sender;
            ope = Operator.Text;
            value = Double.Parse(Visual.Text);
            press = true;
            Label_Proc.Text = value + " " + ope;
        }


        private void Equal(object sender, EventArgs e)
        {
            Label_Proc.Text = "";
            switch (ope)
            {
                case "+":
                    Visual.Text = (value + Double.Parse(Visual.Text)).ToString();
                    break;
                case "-":
                    Visual.Text = (value - Double.Parse(Visual.Text)).ToString();
                    break;
                case "/":
                    Visual.Text = (value / Double.Parse(Visual.Text)).ToString();
                    break;
                case "*":
                    Visual.Text = (value * Double.Parse(Visual.Text)).ToString();
                    break;
            }
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            Visual.Text = "0";
        }

        private void button_minus(object sender, EventArgs e)
        {
            value = Double.Parse(Visual.Text);
            Visual.Text = (value * -1).ToString();
        }

        private void del(object sender, EventArgs e)
        {
            int del = Visual.Text.Length;
            if (del != 1)
                Visual.Text = Visual.Text.Remove(del - 1);
            if (del == 1 || Visual.Text == "-")
                Visual.Text = "0";
        }
    }
}
