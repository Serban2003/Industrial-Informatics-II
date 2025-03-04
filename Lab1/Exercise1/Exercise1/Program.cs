namespace Exercise1;

class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("n for Fibonacci: ");
        try
        {
            n = Int32.Parse(Console.ReadLine());
            int F0 = 0, F1 = 1;
            
            while (n-- > 0)
            {
                int Fn = F1 + F0;
                F0 = F1;
                F1 = Fn;
                Console.Write($"{F0} ");
            }
        }
        catch
        {
            Console.WriteLine("Input is not a number!");
            return;
        }

    }
}