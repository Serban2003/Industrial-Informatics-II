namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double number1 = 0, number2 = 0;
            Console.WriteLine("Number Calculator");
            try
            {
                Console.Write("Write number 1: ");
                number1 = Double.Parse(Console.ReadLine());

                Console.Write("Write number 2: ");
                number2 = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input is not a number!");
            }


            Console.Write("Write operation (+, -, *, /): ");
            char operation = (char)Console.Read();

            if ("+-/*".Contains(operation) == false)
            {
                Console.WriteLine("Invalid operation!");
                return;
            }

            Double result = 0;

            switch (operation)
            {
                case '+':
                {
                    result = NumberOperations.addNumbers(number1, number2);
                    break;
                }
                case '-':
                {
                    result = NumberOperations.subtractNumbers(number1, number2);
                    break;
                }
                case '*':
                {
                    result = NumberOperations.multiplyNumbers(number1, number2);
                    break;
                }
                case '/':
                {
                    result = NumberOperations.divideNumbers(number1, number2);
                    break;
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
