namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            double avg = (a + b) / 2;
            Console.WriteLine("Average = " + avg);

        }
    }
}