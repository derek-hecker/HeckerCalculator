using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        char opToDo = '\0';
        double firstNumber = 0;
        double secondNumber = 0;
        string history = "";
        bool opLastEntered = false;
        //Function to display the number that was clicked on
        private void displayNumberbtnPress(int nmbr)
        {
                if (nmbr >= 0 && nmbr < 10)
                {
                    if (textBox1.Text == "0" && textBox1.Text != null)
                    {
                        textBox1.Text = nmbr.ToString();
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + nmbr.ToString();
                        //int size = textBox1.Text.Length;
                    }
                opLastEntered = false;
                }

        }
        //Function to display the math operation that takes place
        private void displayNumberCharPress(char operation)
        {
            if (!opLastEntered) 
            {
                if (textBox1.Text == "0" && textBox1.Text != null)
                {
                    textBox1.Text = operation.ToString();
                }
                else
                {
                    textBox1.Text = textBox1.Text + operation.ToString();
                }
                opToDo = operation;
                opLastEntered = true;
            }

        }

        //Operation Text Input
            //Multiplication
        private void button11_Click(object sender, EventArgs e)
        {
            displayNumberCharPress('*');
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            displayNumberCharPress('/');
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            displayNumberCharPress('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            displayNumberCharPress('-');
        }
        
        //Operatins that automatically hit equals
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            double num = 0;
            num = Convert.ToDouble(textBox1.Text);
            num = Math.Sqrt(num);
            textBox1.Text = num.ToString();
        }

        private void btnXsquared_Click(object sender, EventArgs e)
        {
            double num = 0;
            num = Convert.ToDouble(textBox1.Text);
            num = num * num;
            textBox1.Text = num.ToString();
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

        private void btnEquals_Click(object sender, EventArgs e)
        {
            history += textBox1.Text;
            string firstNum = "0";
            string secondNum = "0";
            double first;
            double second; 
            double Result = 0;
            int n = 0; 
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == opToDo)
                {
                    n++;
                    continue;
                } else if (n == 0)
                {
                    firstNum += textBox1.Text[i];
                }
                else
                {
                    secondNum += textBox1.Text[i];
                }
            }
            first = Convert.ToDouble(firstNum);
            second = Convert.ToDouble(secondNum);
            if (opToDo == '/' && second == 0)
            {
                textBox1.Text = "Cannot Divide by Zero";
            } else
            {
                if (opToDo == '+')
                {
                    Result = first + second;
                } else if (opToDo == '-')
                {
                    Result = first - second;
                } else if (opToDo == '*')
                {
                    Result = first * second;
                } else if (opToDo == '/')
                {
                    Result = first / second;
                } else if (opToDo == '^')
                {
                   Result = Math.Pow(first, second);
                }
                textBox1.Text = Result.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btn1OverX_Click(object sender, EventArgs e)
        {
            double num = 0;
            num = Convert.ToDouble(textBox1.Text);
            num = 1 / num;
            textBox1.Text = num.ToString();
        }

        private void btnXToTheY_Click(object sender, EventArgs e)
        {
            displayNumberCharPress('^');
        }

        private void btnPlusSlashMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-" + textBox1.Text;
        }
    }
}
