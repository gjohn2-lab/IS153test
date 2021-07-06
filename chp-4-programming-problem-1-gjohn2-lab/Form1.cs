using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chp_4_programming_problem_1_gjohn2_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1DisplayRN_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (readvalue.Text == "1")
                {
                    romanNumeral.Text = "I";
                }
                else if (readvalue.Text == "2")
                {
                    romanNumeral.Text = "II";
                }
                else if (readvalue.Text == "3")
                {
                    romanNumeral.Text = "III";
                }
                else if (readvalue.Text == "4")
                {
                    romanNumeral.Text = "IV";
                }
                else if (readvalue.Text == "5")
                {
                    romanNumeral.Text = "V";
                }
                else if (readvalue.Text == "6")
                {
                    romanNumeral.Text = "VI";
                }
                else if (readvalue.Text == "7")
                {
                    romanNumeral.Text = "VII";
                }
                else if (readvalue.Text == "8")
                {
                    romanNumeral.Text = "VIII";
                }
                else if (readvalue.Text == "9")
                {
                    romanNumeral.Text = "IX";
                }
                else if (readvalue.Text == "10")
                {
                    romanNumeral.Text = "X";
                }
                else 
                {
                    romanNumeral.Text = "Re-Confirm the integer value!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the forms
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
