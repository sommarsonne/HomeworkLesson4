namespace _5_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число");
            //string input = Console.ReadLine();

            int i = 1;
            int b = 30;
            

            while (true)
            {
                
                int v = i + i++;
                if (v < b)
                    Console.WriteLine(v);

                else
                    break;

                
            }

            
         








        }
    }
}
