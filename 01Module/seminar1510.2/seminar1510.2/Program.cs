using System;
using System.Linq;
using System.Collections.Generic;

namespace seminar1510._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string b = Console.ReadLine();

            if (!int.TryParse(b, out int n))
            {
                Console.WriteLine("Incorrect input");
                return;
            }


            int[] mass = new int[n];
            Random rnd = new Random();
            for(int i=0;i<n;i++,Console.WriteLine())
            {
                mass[i] = rnd.Next(1, 10000 + 1);
                Console.WriteLine(mass[i]);
            }





            var str = from s in mass
                      where (s % 3 == 0 & s / 10 != 0 & s / 100 == 0)
                      select s;

            foreach (var i in str)
                Console.WriteLine(i.ToString(), " ") ;




            var str2 = (from s in mass
                      where (s/1000!=0 & s<10000)
                      select s).ToArray().Sum();

            
            foreach (var i in str)
            {

                Console.WriteLine(i.ToString(), " ");

            }
            






        }
        
        








    }
}
