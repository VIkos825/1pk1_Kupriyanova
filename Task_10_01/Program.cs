namespace Task_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину боковой стороны конуса: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус основания конуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            var result = GetArea(sideLength, radius);
            Console.WriteLine("Полная площадь: " + result[0] + "\nБоковая площадь конуса: " + result[1]);

        }
        /// <summary>
        /// возвращает общую и боковую площади
        /// </summary>
        /// <param name="l">боковая сторона</param>
        /// <param name="r">радиус основания</param>
        /// <returns>массив: 1 - полная площадь; 2 - площадь боковой стороны</returns>
        public static double[]  GetArea(double l, double r)
        {
            double[] result = new double[2];
            double sideArea = Math.PI * l * r;
            double fullArea = sideArea + Math.PI * r * r;
            result[0] = fullArea;
            result[1] = sideArea;
            return result;
        }
    }
}
