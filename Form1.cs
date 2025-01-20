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

                for (int t = 1; t < Years; t++)
                {
                    returnAmount = PrincipalAmount * Math.Pow((1 + InterestRateCon / 4), (4 * t));
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
    }
}
