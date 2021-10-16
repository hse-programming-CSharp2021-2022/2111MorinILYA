using System;

namespace classwork2309
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            if (!int.TryParse(a, out int n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int k = 1;
            double s = 0;
            for (int i = 0; i <= n; i++)
            {

                s += (k + 0.3) / (3 * k * k + 5);
                k += 1;

            }

            Console.WriteLine(s);
        }
    }
}
