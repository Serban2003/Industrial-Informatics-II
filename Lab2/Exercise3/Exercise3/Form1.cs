namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNumbers(object sender, EventArgs e)
        {
            try
            {
                Double number1 = Double.Parse(Number1TextBox.Text);
                Double number2 = Double.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 + number2).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        private void SubtractNumbers(object sender, EventArgs e)
        {
            try
            {
                Double number1 = Double.Parse(Number1TextBox.Text);
                Double number2 = Double.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 - number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void MultiplyNumbers(object sender, EventArgs e)
        {
            try
            {
                Double number1 = Double.Parse(Number1TextBox.Text);
                Double number2 = Double.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 * number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DivideNumbers(object sender, EventArgs e)
        {
            try
            {
                Double number1 = Double.Parse(Number1TextBox.Text);
                Double number2 = Double.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 / number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ModulusNumbers(object sender, EventArgs e)
        {
            try
            {
                Double number1 = Double.Parse(Number1TextBox.Text);
                Double number2 = Double.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 % number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ANDNumbers(object sender, EventArgs e)
        {
            try
            {
                int number1 = Int32.Parse(Number1TextBox.Text);
                int number2 = Int32.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 & number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ORNumbers(object sender, EventArgs e)
        {
            try
            {
                int number1 = Int32.Parse(Number1TextBox.Text);
                int number2 = Int32.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 | number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void XORNumbers(object sender, EventArgs e)
        {
            try
            {
                int number1 = Int32.Parse(Number1TextBox.Text);
                int number2 = Int32.Parse(Number2TextBox.Text);
                ResultTextBox.Text = (number1 ^ number2).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
