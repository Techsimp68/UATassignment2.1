using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UATassignment2._1._1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {



        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Simple.Checked)
            {
                //formula to get the simple interest of principal
                int Years = maturityDate.SelectionStart.Year - todaysDate.Value.Year;
                int PrincipalAmount = Convert.ToInt32(DepositAmount.Text);
                decimal InterestRateCon = InterestRate.Value;
                decimal returnAmount = (PrincipalAmount * InterestRateCon * Years) / 100;
                returnAmount = returnAmount + PrincipalAmount;
                //funny if statement
                if (Years >= 150)
                {
                    ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure we will still be using this money? " + Convert.ToString(returnAmount);
                }
                //another funny if statement
                else if (Years >= 80)
                {
                    ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure you can spend that? Whatever the return amount will be! " + Convert.ToString(returnAmount);
                }
                //standard return
                else
                {
                    ReturnAmount.Text = Convert.ToString(returnAmount);
                }
            }
            else
            {
                int Years = maturityDate.SelectionStart.Year - todaysDate.Value.Year; // the formula to find years
                int PrincipalAmount = Convert.ToInt32(DepositAmount.Text); // Principal amount
                double InterestRateCon = Convert.ToDouble(InterestRate.Value) / 100; // conversion of the interest
                double returnAmount;
                int compound;
                if (compoundAmount.Text == "Daily")
                {
                    compound = 365;
                }
                else if (compoundAmount.Text == "Quarterly")
                {
                    compound = 4;
                }
                else
                {
                    compound = 1;
                }
                        for (int t = 1; t < Years; t++)
                        {
                            returnAmount = PrincipalAmount * Math.Pow((1 + InterestRateCon / compound), (compound * t));
                            ReturnAmount.Text = returnAmount.ToString();



                            if (Years < 80)
                            {
                                ReturnAmount.Text = Convert.ToString(returnAmount);
                            }

                            else if (Years >= 150)
                            {
                                ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure we will still be using this money? Whatever the return amount should be" + Convert.ToString(returnAmount);
                            }
                            //another funny if statement
                            else if (Years >= 80 && Years < 150)
                            {
                                ReturnAmount.Text = "Oh Wow " + Years + " years that is amazing! are you sure you can spend that? Whatever the return amount will be! " + Convert.ToString(returnAmount);
                            }
                        }
                }

            }
        

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Dark mode switch to change all the variable colors if checked.
        private void darkMode1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (darkMode1.Checked)
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.WhiteSmoke;
                label2.ForeColor = Color.WhiteSmoke;
                label6.ForeColor = Color.WhiteSmoke;
                label3.ForeColor = Color.WhiteSmoke;
                groupBox1.ForeColor = Color.WhiteSmoke;
                Compound.ForeColor = Color.WhiteSmoke;
                Simple.ForeColor = Color.WhiteSmoke;
                todaysDate.CalendarForeColor = Color.WhiteSmoke;
                todaysDate.CalendarTitleBackColor = Color.Black;
                label5.ForeColor = Color.WhiteSmoke;
                maturityDate.ForeColor = Color.WhiteSmoke;
                label4.ForeColor = Color.WhiteSmoke;
                ReturnAmount.ForeColor = Color.WhiteSmoke;
                ReturnAmount.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.WhiteSmoke;
                DepositAmount.BackColor = Color.Black;
                DepositAmount.ForeColor = Color.WhiteSmoke;
                InterestRate.BackColor = Color.Black;
                InterestRate.ForeColor = Color.WhiteSmoke;
                compoundAmount.ForeColor = Color.Black;
                compoundAmount.BackColor = Color.Black;
                maturityDate.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                label1.ForeColor = Color.DimGray;
                label2.ForeColor = Color.DimGray;
                label6.ForeColor = Color.DimGray;
                label3.ForeColor = Color.DimGray;
                groupBox1.ForeColor = Color.DimGray;
                Compound.ForeColor = Color.DimGray;
                Simple.ForeColor = Color.DimGray;
                todaysDate.CalendarForeColor = Color.DimGray;
                todaysDate.CalendarTitleBackColor = Color.White;
                label5.ForeColor = Color.DimGray;
                maturityDate.ForeColor = Color.DimGray;
                label4.ForeColor = Color.DimGray;
                ReturnAmount.ForeColor = Color.DimGray;
                ReturnAmount.BackColor = Color.White;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.DimGray;
                DepositAmount.BackColor = Color.White;
                DepositAmount.ForeColor = Color.DimGray;
                InterestRate.BackColor = Color.White;
                InterestRate.ForeColor = Color.DimGray;
                compoundAmount.ForeColor = Color.DimGray;
                compoundAmount.BackColor = Color.White;
                maturityDate.BackColor = Color.White;
            }

        }
    }
}
