using System;

namespace dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            double g=0;
            double x = Console.Read();


            if (x<=0.5)
            {
                g = Math.Sin(90 * Math.PI / 180);
            }


            if (x > 0.5)
            {
                g = Math.Sin(90 * (Math.PI / 180)*(x-1));
            }

            Console.WriteLine(g);


        }
    }
}
