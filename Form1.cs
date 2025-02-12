using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace calc
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        char op;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(!(txt_display.Text.Contains('.')&& (((Guna2Button)sender).Text==".")))
            txt_display.Text += ((Guna2Button)sender).Text;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2= Convert.ToDouble(txt_display.Text);
            switch(op)
            {
                case '+':
                  result=  num1 + num2 ;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '×':
                    result = num1 * num2;
                    break;

                case '÷':
                    result = num1 / num2;
                    break;

                case '%':
                    result = num1 % num2;
                    break;


            }
            txt_display.Text = result.ToString();
            op = 'n';
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            txt_display.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txt_display.Text!="")
            {
                txt_display.Text = txt_display.Text.Remove(txt_display.Text.Length - 1);
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if(op=='n')
            {
                op = ((Guna2Button)sender).Text[0];
                num1 = Convert.ToDouble(txt_display.Text);
                txt_display.Clear();
            }
            else
            {
                op = ((Guna2Button)sender).Text[0];
                txt_display.Clear();

            }

        }
    }
}
