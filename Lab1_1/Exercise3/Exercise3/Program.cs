namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Select conversion: ");

            int option = 0;
            Double temp = 0.0;

            try
            {
                option = Int32.Parse(Console.ReadLine());

                if(option != 1 && option != 2)
                {
                    Console.WriteLine("Invalid option!");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid option!");
                return;
            }

            Console.Write("Input temperature: ");

            try
            {
                temp = Double.Parse(Console.ReadLine());
                if(option  == 1)
                {
                    Console.WriteLine($"{temp}°C = {convertCelsiusInFahrenheit(temp)}°F");
                }
                else
                {
                    Console.WriteLine($"{temp}°F = {convertFahrenheitInCelsius(temp)}°C");
                }

            }
            catch
            {
                Console.WriteLine("Input is not a number!");
                return;
            }
        }

        public static Double convertCelsiusInFahrenheit(Double celsius)
        {
            return Math.Round(celsius * 9 / 5 + 32, 2);
        }

        public static Double convertFahrenheitInCelsius(Double fahrenheit)
        {
            return Math.Round((fahrenheit - 32) * 5 / 9, 2);
        }
    }
}
