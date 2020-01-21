using System;

namespace for20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, mini = 1;
            float sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                mini *= i;
                sum += mini;
            }
            Console.WriteLine(sum);
        }
    }
}
