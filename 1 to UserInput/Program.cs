namespace _5_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int rangeLimit = int.Parse(Console.ReadLine());

            int start = 0;
            int rangeSum = 0;


            while (start != rangeLimit)
            {
                start++;
                rangeSum = rangeSum + start;
            }

            Console.WriteLine($"Сумма чисел в диапазоне от 1 до {rangeLimit} равна " +  rangeSum);
        }
    }
}
