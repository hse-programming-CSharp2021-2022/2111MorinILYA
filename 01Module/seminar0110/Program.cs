using System;

namespace seminar0110
{
    class Program
    {
        public static void Print(int[] mas)
        {
            foreach (var el in mas)
                Console.Write(el + " ");
            Console.WriteLine();


        }

        static void Main(string[] args)
        {
            string b = Console.ReadLine();

            if (!int.TryParse(b, out int n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Random random = new Random();

            int[] mas;
            mas = new int[n];
            mas[0] = random.Next(0, 1000 + 1);
            for (int i = 1; i < mas.Length; i++)
            {
                mas[i] = random.Next(0, 1000 + 1);



            }
            Print(mas);

            Array.Sort(mas, (a, b) =>
            {
                a = Math.Abs(a); b = Math.Abs(b);
                if (a % 2 == 1 & b % 2 == 0) return 1;
                if (a % 2 == 0 & b % 2 == 1) return -1;
                return 0;
            });
            Print(mas);

            Array.Sort(mas, (a, b) =>
            {
                a = Math.Abs(a); b = Math.Abs(b);
                if ((a /1000 > 0 & b /1000 == 0)| (a / 100 > 0 & b / 100 == 0)| (a / 10 > 0 & b / 10 == 0)) return 1;
                if ((a /1000 == 0 & b % 1000 > 0)| (a / 100 ==0 & b / 100 > 0)|( a / 10 == 0 & b / 10 > 0)) return -1;
                return 0;
            });
            Print(mas);

            

        }
    }
}
