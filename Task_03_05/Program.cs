namespace Task_03_05
{
    internal class Program
    {
        /*
        Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
        Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
        время работы программы
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаппазон температур(в градусах цельсия)");
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            for (int i = c1; i < c2+1; i++) 
            {
                double f = i * 1.8 + 32;
                Console.WriteLine(i + "C = " + f + "F");
            }
            

            
             
        }
    }
}
