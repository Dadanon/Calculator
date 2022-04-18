namespace Calculator
{
    public partial class Form1 : Form
    {
        private List<decimal> NumbersMemory = new List<decimal>(2);
        private List<string> OperatorsMemory = new List<string>(1);
        private List<string> Operators = new List<string>() { "+", "-", "*", "/"};

        private void operation(string oper)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (!string.IsNullOrEmpty(textBox2.Text) | !string.IsNullOrEmpty(textBox1.Text) && !textBox1.Text.EndsWith(","))
                {
                    if (NumbersMemory.Count == 0)
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text));
                    }
                    else if ((NumbersMemory.Count == 1) && (!Operators.Contains(textBox1.Text)))
                    {
                        if (!string.IsNullOrEmpty(textBox1.Text))
                        {
                            NumbersMemory.Add(Convert.ToDecimal(textBox1.Text));
                            decimal result = 0;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        break;
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        break;
                                    }
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    break;
                            }
                            NumbersMemory.Clear();
                            NumbersMemory.Add(result);
                            OperatorsMemory.Clear();
                        }
                    }
                    if (!textBox2.Text.Equals("ERROR"))
                    {
                        textBox1.Text = oper;
                    }
                    else
                    {
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void click(string number)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (!textBox1.Text.Equals("0"))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        textBox1.Text += number;
                    }
                    else
                    {
                        OperatorsMemory.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text += number;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click("4"); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            click("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (!textBox1.Text.Equals("0"))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        textBox1.Text += "0";
                    }
                    else
                    {
                        OperatorsMemory.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Text += "0";
                    }
                }
            } 
        }

        // Divide button
        private void button11_Click(object sender, EventArgs e)
        {
            operation("/");
        }

        // Multiply button
        private void button12_Click(object sender, EventArgs e)
        {
            operation("*");
        }

        // Minus button
        private void button13_Click(object sender, EventArgs e)
        {
            operation("-");
        }

        // Plus button
        private void button14_Click(object sender, EventArgs e)
        {   
            operation("+");
        }

        // Delete button
        private void button15_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text[0..^1];
                }
            }
        }

        // Comma button
        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (!textBox1.Text.Contains(','))
                    {
                        if (!Operators.Contains(textBox1.Text))
                        {
                            textBox1.Text += ",";
                        }
                    }
                }
            }
        }

        // Clear button
        private void button17_Click(object sender, EventArgs e)
        {
            NumbersMemory.Clear();
            OperatorsMemory.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Equals button
        private void button18_Click(object sender, EventArgs e)
        {
            if (!Operators.Contains(textBox1.Text))
            {
                operation("*");
                textBox1.Text = "";
            }
        }

        // Invert button
        private void button19_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals("ERROR"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        if (textBox1.Text != "0")
                        {
                            decimal invert = Convert.ToDecimal(textBox1.Text) * (-1);
                            textBox1.Text = invert.ToString();
                        }
                    }
                }
            }
        }
    }
}