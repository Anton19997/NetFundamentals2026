
namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введіть ваш вік: ");
            
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть ваш зріст: ");

            int hight = int.Parse(Console.ReadLine());

             Console.WriteLine("Введіть вашу вагу: ");

            int weight = int.Parse(Console.ReadLine());
            if (age <= 12)
                {Console.WriteLine("Ви занадто молоді");
                }
            else if (hight <= 140 && hight >= 200)
                {
                Console.WriteLine("Зріст не відповідає нормам безпеки");
                }
            else if (weight > 120 )
                {
                Console.WriteLine("Перевищення ліміту ваги");
                }
            else 
            {Console.WriteLine("Ласкаво просимо на атракціон!");}
           


        }
    }
}
