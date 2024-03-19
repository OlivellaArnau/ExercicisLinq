using System;
using System.Linq;


namespace ExercicisLinq
{
    public class Program
    {
        public static void Main()
        {
            Ex26();
            Ex27();
            Ex28();
            
        }

        public static void Ex26()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var myQuery = from num in array
                          where num % 2 == 0
                          select num;

            Console.WriteLine("Nombres parells:");
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);
            }
        }

        public static void Ex27()
        {
            int[] array = { 1, -2, -3, 4, 5, 6 };
            var myQuery = from num in array
                          where num >= 0
                          select num;

            Console.WriteLine("Nombres positius:");
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);

            }
        }

        public static void Ex28()
        {
            int[] array = {15,16,17,18,19,20,21,22,23};

            var myQuery = from num in array
                          where num >= 20
                          select num;

            Console.WriteLine("Numeros majors que 20 en la seva potencia");
            foreach (var item in myQuery)
            {
                Console.WriteLine(item * item);
                
            }
        }

        public static void Ex29()
        {

        }

    }
}