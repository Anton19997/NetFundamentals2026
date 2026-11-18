
namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int purchases = 0;
            double bill = 0;

            while(bill < 5000)
            {   Console.WriteLine("ВВедіть вартітсь товару");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double item))
                {
                    Console.WriteLine("Некоректний ввід даних, введено не число");
                    continue;
                }

                if(item < 0)
                {
                    Console.WriteLine("Невірно введене значення");
                    continue;
                }
                
                if(item == 0)
                {
                    Console.WriteLine("До зустрічі");
                    break;                   
                }

                if(item > 2000)
                {
                    Console.WriteLine("Зачекайте адміністратора");
                    Console.WriteLine("Підтверджуєте покупку?");
                    string answer = Console.ReadLine().ToLower();

                    if(answer != "так")
                    {
                        Console.WriteLine("Покупку не дозволено");
                        continue;
                    }
                }

                purchases++;

                if (purchases % 3 == 0)
                {
                    item = item * 0.9;
                    Console.WriteLine("Знижка 10% за третій товар у чеку");                   
                }

                bill += item;
                Console.WriteLine($"Поточний баланс: {bill} грн");

                if(bill >= 5000)
                {
                    Console.WriteLine("ВІТАЄМО ви VIP");
                    Console.WriteLine(bill);
                    return;
                }

                Console.WriteLine("Ваш баланс: " + bill.ToString() + " грн");
            }
        }
    }
}