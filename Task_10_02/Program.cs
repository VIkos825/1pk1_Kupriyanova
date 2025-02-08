namespace Task_10_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число факториалла: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long fact = 0;

            while (n > 0)
            {
                fact += Factorial(n);
                n--;
            }

            Console.WriteLine("Сумма факториалов = " + fact);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k">число факториала</param>
        /// <returns>вакториал</returns>
        public static long Factorial(int k)
        {
            long res = 1;
            while (k > 0)
            {
                res *= k;
                k--;
            }
            return res;
        }
    }
}
