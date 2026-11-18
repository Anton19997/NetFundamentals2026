namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введіть номер місяця: ");
         int day = int.Parse(Console.ReadLine());    
         switch(day)
            { 
                case 1:
                    Console.WriteLine($"{day} - Січень 31 день");
                    break;

                case 2:
                    Console.WriteLine("Чи є рік високонсим?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.WriteLine($"{day} - Лютий 29 днів");
                    } 
                    else
                    {
                        Console.WriteLine($"{day} - Лютий 28 днів");
                    }
                    break;

                case 3:
                    Console.WriteLine($"{day} - Березень 31 день");
                    break;

                case 4:
                    Console.WriteLine($"{day} - Квітень 30 днів");
                    break;

                case 5:
                    Console.WriteLine($"{day} - Травень 31 день");
                    break;

                case 6:
                    Console.WriteLine($"{day} - Червень 30 днів");
                    break;
                case 7:
                    Console.WriteLine($"{day} - Липень 31 день");
                    break;

                case 8:
                    Console.WriteLine($"{day} - Серпень 31 день");
                    break;

                case 9:
                    Console.WriteLine($"{day} - Вересень 30 днів");
                    break;

                case 10:
                    Console.WriteLine($"{day} - Жовтень 31 день");
                    break;

                case 11:
                    Console.WriteLine($"{day} - Листопад 30 днів");
                    break;

                case 12:
                    Console.WriteLine($"{day} - Грудень 31 день");
                    break;

                default:
                    Console.WriteLine("Введено невірне число");
                    break;




                
            }  



        }
    }
}