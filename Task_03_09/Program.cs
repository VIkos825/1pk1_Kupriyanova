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
            int x = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            for (double i = x; i < y; i *= (100+p)/100)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
