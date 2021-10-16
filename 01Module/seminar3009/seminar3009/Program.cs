using System;

namespace seminar3009
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
            int n = 10;
            Random random = new Random();

            int[] mas; 
            mas = new int[n];
            mas[0] = random.Next(1, 10 + 1);
            for (int i = 1; i < mas.Length; i++)
            {
                mas[i] = random.Next(1, 10 + 1);
                if (mas[i - 1] != mas[i])
                {
                    mas[i] = mas[i];
                }
                else
                {
                    mas.RemoveAt(mas.IndexOf(i));

                }


            }
            Print(mas);


            

            

            



        }
        
        






    }
}
