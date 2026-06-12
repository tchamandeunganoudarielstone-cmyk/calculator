namespace calculator
{
    public partial class Form1 : Form
    {
        double stokagetxtbx = 0;

        double stokasetxtbx = 0;

        double result = 0;

        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                stokagetxtbx = double.Parse(textBox1.Text);
                operation = "x";
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                stokagetxtbx = double.Parse(textBox1.Text);
                operation = "+";
                textBox1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                stokagetxtbx = double.Parse(textBox1.Text);
                operation = "-";
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                stokagetxtbx = double.Parse(textBox1.Text);
                operation = "/";
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.Contains(",") == false)
            {
                textBox1.Text += ",";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            stokasetxtbx = double.Parse(textBox1.Text);

            textBox1.Text = "";

            if ( operation == "+")
            {
                result = stokagetxtbx + stokasetxtbx;

                textBox1.Text = result.ToString();
            }
            else if ( operation == "-") {
                result = stokagetxtbx - stokasetxtbx;
                textBox1.Text = result.ToString();
            }
            else if (operation == "x")
            {
                result = stokagetxtbx * stokasetxtbx;
                textBox1.Text = result.ToString();
            }
            else if (operation == "/")
            {
                result = stokagetxtbx / stokasetxtbx;
                textBox1.Text = result.ToString();
            }
        }
    }
}
