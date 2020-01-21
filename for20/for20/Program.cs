using System;

namespace for20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =  1;
            float sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                sum = n * i;
            }
            Console.WriteLine(sum);

        }
    }
}
