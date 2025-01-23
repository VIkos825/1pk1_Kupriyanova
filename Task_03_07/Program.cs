namespace Task_03_07
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела
        v = g*t, где 2 g = 9,8 м/с2 – ускорение свободного падения.*/
        static void Main(string[] args)
        {
            double v = 0;
            double g = 9.8;
            Console.WriteLine("Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела\r\n        v = g*t, где 2 g = 9,8 м/с2 – ускорение свободного падения.");
            Console.WriteLine("Введите время падения тела:");
            double c = double.Parse(Console.ReadLine());
            for (double t = 0.5; t <= c; t += 0.5)
            {
                v = g * t;
                Console.WriteLine(v + " м/с");
            }
        }
    }
}
