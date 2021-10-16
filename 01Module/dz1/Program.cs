using System;

namespace dz1
{
    class Program
    {
        static void Main()
        {
            double G=0;
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            if (!int.TryParse(x, out int x1))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            if (!int.TryParse(y, out int y1))

            {
                Console.WriteLine("Incorrect input");
                return;
            }


            if (x1<y1&&x1>0)
            {

                G = x1 + Math.Sin(y1);

            }

            if (x1>y1&&x1<0)
            {

                G = y1 - Math.Cos(x1);

            }

            else
            {

                G = 0.5 * x1 * y1;

            }



            Console.WriteLine(G);












        }
    }
}
