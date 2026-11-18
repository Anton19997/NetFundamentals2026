namespace Homework8
{
    internal class Program
    {enum Quarter 
        {   
            First, 
            Second, 
            Third, 
            Fourth, 
            OnAxis, 
            Origin
                
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Введіть значення х");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть значення у");
        double y = double.Parse(Console.ReadLine());

        double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        if (dist > 100)
            {Console.WriteLine("Точка занадто далеко");
            return;               
            } 
        
        Quarter res = (x, y) switch
            {
            (>0, >0) => Quarter.First,
            (<0, >0) => Quarter.Second,
            (<0, <0) => Quarter.Third,
            (>0, <0) => Quarter.Fourth,
            (0, 0) => Quarter.Origin,
            _ => Quarter.OnAxis  
            };
        Console.WriteLine(res);


        }
    }
}
