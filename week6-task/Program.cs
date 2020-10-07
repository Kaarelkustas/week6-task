using System;

namespace week6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];

            for(int i = 0; i <numbers.Lenght; i++)
            {
                numbers[i] = rnd.Next(1, 11);
            }
                int sum = 0;  
              foreach(int num in numbers)
            {
                sum = sum + num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"total: {sum}");
        }   
    }
}
