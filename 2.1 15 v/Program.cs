using System;

namespace _2._1_15_v
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 Высокий уровень
            try
            {

                Console.WriteLine("введите x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("введите y");
                double y = double.Parse(Console.ReadLine());
                if (x <= 2 && y <= 2 && x >= 0 && y >= 0 && x + y >= 1 && x + y <= 3) Console.WriteLine("да");
                else Console.WriteLine("нет");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
