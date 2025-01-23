using System.Runtime.InteropServices;

namespace Task_03_09
{
    internal class Program
    {
        /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная 
         часть копеек отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько
         лет вклад составит не менее y рублей.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вклад в банке: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент увеличения вклада: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную сумму вклада: ");
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            for (double i = x; i < y; i *= (100+p)/100)
            {
                i = (int)i;
                count++;
            }
            Console.WriteLine("Вклад достигнет " + y + " рублей через " + count + " лет.");
        }
    }
}
