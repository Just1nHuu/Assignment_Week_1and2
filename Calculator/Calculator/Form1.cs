namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

  
        private void buttonplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;
            
            if (option.Equals("%"))
                result = num1 % num2;

            txtDisplay.Text = result + "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            f = Convert.ToString(num1);
            s = Convert.ToString(num2);

            f = "";
            s = "";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void txtDisplay_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonmod_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }


        //private void EnterNumbers(object sender, EventArgs e)
        //{
        //    Button num = (Button)sender;
        //    if (txtDisplay.Text == "0")
        //        txtDisplay.Text = "";
        //        {
        //            if (num.Text == ".")
        //            {
        //                if (!txtDisplay.Text.Contains("."))
        //                    txtDisplay.Text = txtDisplay.Text + num.Text;
        //            }
        //            else
        //            {
        //                txtDisplay.Text = txtDisplay.Text + num.Text;
        //            }   
        //        }

        //}

    }
}
