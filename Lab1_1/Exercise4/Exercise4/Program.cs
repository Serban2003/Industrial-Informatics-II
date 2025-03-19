namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char gender;
            double height, age;

            Console.WriteLine("BMI Calculator");
            Console.Write("Insert gender (f, m): ");
            gender = (char)Console.Read();
            Console.ReadLine();

            if("fm".Contains(gender) == false)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            try
            {
                Console.Write("Insert height (cm): ");
                height = Double.Parse(Console.ReadLine());

                Console.Write("Insert age: ");
                age = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            IdealWeight idealWeight = new IdealWeight(height, age, gender);
            idealWeight.displayIdealWeight();
        }
    }
}
