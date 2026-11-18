using System.Runtime.ConstrainedExecution;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введіть вартість першого товару");
        int item1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть вартість другого товару");
        int item2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть вартість третього товару");
        int item3 = int.Parse(Console.ReadLine());

        int total = item1 + item2 + item3;
        Console.WriteLine(total);

        int average = (item1 + item2 + item3)/3;
        Console.WriteLine(average);

        Console.WriteLine("Введіть день тижня");
        int day = int.Parse(Console.ReadLine());

        switch(day)
            {
                case 1:
                    Console.WriteLine(total + (total * 0.05));
                    break;
                
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(total);
                    break;
                
                case 7:
                    Console.WriteLine(total - (total * 0.15));
                    break;


                
            }

        }
    }
}