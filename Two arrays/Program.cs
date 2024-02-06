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

            int arraySum1 = array1.Sum();
            int arraySum2 = array2.Sum();

            int array1Length = array1.Length;
            int array2Length = array2.Length;

            double ariphmeticMean1 = arraySum1 / array1Length;
            double ariphmeticMean2 = arraySum2 / array2Length;

            Console.WriteLine();
            
            if (ariphmeticMean1 > ariphmeticMean2)
                Console.WriteLine("Среднее арифметическое первого массива больше");
            
            else if (ariphmeticMean2 > ariphmeticMean1)
                Console.WriteLine("Среднее арифметическое второго массива больше");
            
            else if (ariphmeticMean1 == ariphmeticMean2) 
                Console.WriteLine("Среднее арифметическое массивов равны");
        }
    }

}
