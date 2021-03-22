using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable for calculation
        double valOne, valTwo;

        //Variable for trigger buttons
        bool add = false;
        bool sub = false;
        bool mul = false;
        bool dev = false;

        //Method for add textbox value to"ValOne"
        private void valOneMethod() 
        {
                valOne += double.Parse(txtCal.Text);
                txtCal.Clear();
                add = false;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 8;
        }

        private void bynNine_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 9;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

            int c = txtCal.Text.Length;
            int flag = 0;
            string text = txtCal.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtCal.Text = txtCal.Text + ".";
            }  
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try 
            {
                valOneMethod(); 
                dev = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter A Value");
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                valOneMethod();
                mul = true;
            }
            catch (Exception) 
            {
                MessageBox.Show("Please Enter A Value");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                valOneMethod();
                sub = true;
            }
            catch (Exception) 
            {
                txtCal.Text = "-";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                valOneMethod();
                add = true;
            }
            catch (Exception)
            {
                txtCal.Text = "+";
            }
        }

        //When Click One of "/" , "*" , "-" , "+" Button Following Condition Whill Be True
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (add == true) 
            {
                valTwo = valOne + double.Parse(txtCal.Text);    //Assign valOne value + textbox value to "ValTwo"
            }
            else if(mul==true)
            {
                valTwo = valOne * double.Parse(txtCal.Text);     //Assign valOne value * textbox value to "ValTwo"
            }
            else if(dev==true)
            {
                valTwo = valOne / double.Parse(txtCal.Text);     //Assign valOne value / textbox value to "ValTwo"
            }
            else if (sub == true) 
            {
                valTwo = valOne - double.Parse(txtCal.Text);     //Assign valOne value - textbox value to "ValTwo"
            }
           
            txtCal.Text = valTwo.ToString();        //valTwo value display in textbox       
            valOne = 0;                             //Clear valOne Value
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCal.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                String text = txtCal.Text;
                if (text != null)
                {
                    txtCal.Text = text.Remove(text.Length - 1, 1);
                }
            }
            catch (Exception) 
            {
                txtCal.Text = "0";
            }
        }


        //KeyMapping
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D1:
                    btnOne.PerformClick();
                    return true;

                case Keys.NumPad1:
                    btnOne.PerformClick();
                    return true;

                case Keys.D2:
                    btnTwo.PerformClick();
                    return true;

                case Keys.NumPad2:
                    btnTwo.PerformClick();
                    return true;

                case Keys.D3:
                    btnThree.PerformClick();
                    return true;

                case Keys.NumPad3:
                    btnThree.PerformClick();
                    return true;

                case Keys.D4:
                    btnFour.PerformClick();
                    return true;

                case Keys.NumPad4:
                    btnFour.PerformClick();
                    return true;

                case Keys.D5:
                    btnFive.PerformClick();
                    return true;

                case Keys.NumPad5:
                    btnFive.PerformClick();
                    return true;

                case Keys.D6:
                    btnSix.PerformClick();
                    return true;

                case Keys.NumPad6:
                    btnSix.PerformClick();
                    return true;

                case Keys.D7:
                    btnSeven.PerformClick();
                    return true;

                case Keys.NumPad7:
                    btnSeven.PerformClick();
                    return true;

                case Keys.D8:
                    btnEight.PerformClick();
                    return true;

                case Keys.NumPad8:
                    btnEight.PerformClick();
                    return true;

                case Keys.D9:
                    bynNine.PerformClick();
                    return true;

                case Keys.NumPad9:
                    bynNine.PerformClick();
                    return true;

                case Keys.D0:
                    btnZero.PerformClick();
                    return true;

                case Keys.NumPad0:
                    btnZero.PerformClick();
                    return true;

                case Keys.Decimal:
                    btnDecimal.PerformClick();
                    return true;

                case Keys.Add:
                    btnAdd.PerformClick();
                    return true;

                case Keys.Subtract:
                    btnSub.PerformClick();
                    return true;

                case Keys.Multiply:
                    btnMultiple.PerformClick();
                    return true;

                case Keys.Divide:
                    btnDivide.PerformClick();
                    return true;

                case Keys.Clear:
                    btnClear.PerformClick();
                    return true;

                case Keys.Delete:
                    btnClear.PerformClick();
                    return true;

                case Keys.Enter:
                    btnEqual.PerformClick();
                    return true;

                case Keys.Back:
                    btnBack.PerformClick();
                    return true;

            }
            return base.ProcessCmdKey(ref msg, keyData);
        } 
    }
}
