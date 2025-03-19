namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Calculator");
            Double[] numbers;
            int n;

            try
            {
                Console.Write("How many numbers?: ");
                n = Int32.Parse(Console.ReadLine());

                numbers = new Double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Insert number: ");
                    numbers[i] = Double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Arithmetic Average: {calculateArithmeticAverage(n, numbers)}");
                Console.WriteLine($"Geometric Average: {calculateGeometricAverage(n, numbers)}");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }
        public static Double calculateArithmeticAverage(int n, Double[] numbers)
        {
            Double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += numbers[i];
            }

            return result / n;
        }

        public static Double calculateGeometricAverage(int n, Double[] numbers)
        {
            Double result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= numbers[i];
            }

            return Math.Round(Math.Pow(result, (double) 1 / n), 2);
        }
    }
}
