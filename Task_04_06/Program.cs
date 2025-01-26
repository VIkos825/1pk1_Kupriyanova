using System;

namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по
        модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть
        двух равных по модулю. В полученном массиве найти наибольшее по модулю число.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел: ");//задаем кол-во значений
            int countOfNums = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите диапазон значений: ");//задаем диапазон 
            int rangeOfNums1 = int.Parse(Console.ReadLine());
            int rangeOfNums2 = int.Parse(Console.ReadLine());

            int[] nums = new int[countOfNums];
            Random rnd = new Random();
            Console.WriteLine();

            for (int i = 0; i < nums.Length; i++)
            {
                int e = rnd.Next(rangeOfNums1,rangeOfNums2);
                if (nums.Contains(e) && nums.Contains(-e))
                {
                    nums[i] = e;

                }
                Console.WriteLine(nums[i]);
            }
        }
    }
}





/*int e = random.Next(0, 101);
if (array.Contains(e))
{
    count++;
    array[i] = e;
}
else array[i] = e;*/
