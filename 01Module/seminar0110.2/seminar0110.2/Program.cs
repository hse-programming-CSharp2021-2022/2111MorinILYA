using System;

namespace seminar0110._2
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
            Random random = new Random();

            int[][] b = new int[n][];
            for (int i=0;i<b.Length;i++)
            {
                b[i] = new int[random.Next(5, 7 + 1)];


            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < b[i].Length; j++)
                    b[i][j] = random.Next(-10, 10 + 1);

            Array.ForEach(b, el =>
            {
                 Array.ForEach(el, elem => Console.Write($"{elem} "));
                 Console.WriteLine();


            });


         

            
            






            Array.ForEach(b, el =>
            {
                Array.ForEach(el, elem => Console.Write($"{elem} "));
                Console.WriteLine();


            });










        }
    }
}
