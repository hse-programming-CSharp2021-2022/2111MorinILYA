using System;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();



            if (!int.TryParse(b, out int a))
            {
                Console.WriteLine("Incorrect input");
                return;
            }


            if (a == 1 | a == 2 | a == 3)
            {
                Console.WriteLine("Неудовлетворительно");

            }


            if (a == 4 | a == 5)
            {

                Console.WriteLine("Удовлетворительно");
            }


            if (a == 6 | a == 7)
            {


                Console.WriteLine("Хорошо");

            }



            if (a == 8 | a == 9 | a == 10)
            {


                Console.WriteLine(" Отлично");


            }
        }
    }
}
