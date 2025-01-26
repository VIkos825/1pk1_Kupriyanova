namespace Task_02_02
{
    internal class Program
    {
        /*Найти значение выражения при a = 8, b = 14, с = π/4*/
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            double part11 = Math.Cbrt(a - 1);
            double part12 = Math.Sqrt(Math.Sqrt(b+part11));
            double part21 = Math.Abs(a - b);
            double part22 = Math.Pow(Math.Sin(c), 2) + Math.Tan(c);
            Console.WriteLine(part12 / (part21*part22));
        }
    }
}
