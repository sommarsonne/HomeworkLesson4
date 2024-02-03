using System;

namespace Two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = [1, 3, 5, 55, 9];
            int[] array2 = [4, 5, 3, 2, 100];

            foreach (var num in array1)
            {
                //Console.Write($" ==> {string.Join(" ==> ", array1)}"); Получилось без гугла
                Console.Write($"{num} ");
            }

            Console.WriteLine();
           
            foreach (var num2 in array2)
            {
                Console.Write($"{num2} ");
            }

            int sum1 = array1.Sum();
            int sum2 = array2.Sum();

            int array1length = array1.Length;
            int array2length = array2.Length;

            double am1 = sum1 / array1length;
            double am2 = sum2 / array2length;

            Console.WriteLine();
            
            if (am1 > am2)
                Console.WriteLine("Среднее арифметическое первого массива больше");
            
            else if (am2 > am1)
                Console.WriteLine("Среднее арифметическое второго массива больше");
            
            else if (am1 == am2) 
                Console.WriteLine("Среднее арифметическое массивов равны");
        }
    }

}
