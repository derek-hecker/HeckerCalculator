using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeckerCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void displayNumberbtnPress(int nmbr)
        {
            if (nmbr >= 0 && nmbr < 10)
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = nmbr.ToString();
                }else
                {
                    textBox1.Text = textBox1.Text + nmbr.ToString();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void btnSQRT_Click(object sender, EventArgs e)
        {

        }

        private void btnXsquared_Click(object sender, EventArgs e)
        {

        }


        //Number Button Section
        private void btnN0_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(0);
        }
        private void btnN1_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(1);
        }
        private void btnN2_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(2);
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(3);
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(4);
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(5);
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(6);
        }
            // Number 7, created button before renaming
        private void button12_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(7);
        }

        private void btnN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            displayNumberbtnPress(2);
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(8);
        }
            //Number 9, created before naming button
        private void button10_Click(object sender, EventArgs e)
        {
            displayNumberbtnPress(9);
        }

    }
}
