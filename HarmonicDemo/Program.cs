using System;

namespace HarmonicDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any value");

            int N = Convert.ToInt32(Console.ReadLine());
            if (N != 0)
            {
                double sum = 0;


                for (double i = 1; i <= N; i++)
                {

                    sum += (1 / i);
                }
                Console.WriteLine(" harmonic no: is " + sum);


            }
            else
            {
                Console.WriteLine("zero is not a valid value try another value");
            }

        }

    }
}