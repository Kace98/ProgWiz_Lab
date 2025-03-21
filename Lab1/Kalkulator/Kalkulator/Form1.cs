namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private string currentNumber = "";
        private double? firstNumber = null;
        private string operation = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateDisplay()
        {
            label1.Text = currentNumber;
        }

        private void AddDigit(string digit)
        {
            if (isNewNumber)
            {
                currentNumber = digit;
                isNewNumber = false;
            }
            else
            {
                currentNumber += digit;
            }
            UpdateDisplay();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void PerformOperation(string newOperation)
        {
            if (!string.IsNullOrEmpty(currentNumber))
            {
                if (firstNumber.HasValue)
                {
                    button_eq_Click(null, null);
                }
                firstNumber = double.Parse(currentNumber);
                operation = newOperation;
                isNewNumber = true;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void button_devide_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            if (firstNumber.HasValue && !string.IsNullOrEmpty(currentNumber) && !string.IsNullOrEmpty(operation))
            {
                double secondNumber = double.Parse(currentNumber);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber.Value + secondNumber;
                        break;
                    case "-":
                        result = firstNumber.Value - secondNumber;
                        break;
                    case "*":
                        result = firstNumber.Value * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber.Value / secondNumber;
                        }
                        else
                        {
                            MessageBox.Show("Nie można dzielić przez zero!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                currentNumber = result.ToString();
                UpdateDisplay();
                firstNumber = null;
                operation = "";
                isNewNumber = true;
            }
        }

        private void button_reverse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber) && currentNumber.Length > 0)
            {
                currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                if (string.IsNullOrEmpty(currentNumber))
                {
                    currentNumber = "0";
                    isNewNumber = true;
                }
                UpdateDisplay();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                currentNumber = "0,";
                isNewNumber = false;
            }
            else if (!currentNumber.Contains(","))
            {
                currentNumber += ",";
            }
            UpdateDisplay();
        }
    }
}
