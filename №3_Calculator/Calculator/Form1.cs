namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstValue;
        string arithmetic;
        double SecondValue;
        double outcome;
        string save;
        string error = "НЕ ДОПУСТИМАЯ ОПЕРАЦИЯ";
        //Обработчик числовых кнопок.
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "1";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "2";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "3";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "4";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "5";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "6";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "7";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "8";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "9";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "0";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "0";
            }
        }
        //Обработчик операционных кнопок.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "0";
            arithmetic = "+";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "0";
            arithmetic = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "0";
            arithmetic = "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "0";
            arithmetic = "/";
        }

        //Прочие обработчики.

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(textBoxResult.Text);
            if (arithmetic == "+")
            {
                outcome = (FirstValue + SecondValue);
                textBoxResult.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "-")
            {
                outcome = (FirstValue - SecondValue);
                textBoxResult.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "*")
            {
                outcome = (FirstValue * SecondValue);
                textBoxResult.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0)
                {
                    textBoxResult.Text = error;
                }
                else
                {
                    outcome = FirstValue / SecondValue;
                    textBoxResult.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text != error)
                textBoxHistory.Text = textBoxResult.Text;
            textBoxResult.Text = "0";
        }
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + ",";
        }
        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.White)
            {
                this.BackColor = System.Drawing.Color.Gray;
                textBoxResult.ForeColor = System.Drawing.Color.White;
                textBoxHistory.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
                textBoxResult.ForeColor = System.Drawing.Color.Black;
                textBoxHistory.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBoxResult.Text);
            outcome = (FirstValue * -1);
            textBoxResult.Text = Convert.ToString(outcome);
            FirstValue = outcome;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            save = textBoxResult.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = save;
            FirstValue = outcome;
        }
    }
}
