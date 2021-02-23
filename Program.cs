using System;


namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, i, j;
            int sum = 0, sum1 = 0, sum2 = 0;

            int[,] intArray = new int[5, 5]
            {
                {1,2,3,4,5 },
                { 6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20 },
                {21,22,23,24,25 }
            };
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a = intArray[i, j];
                    Console.Write($" {a} ");//print array from column loop
                    sum += intArray[i, j];

                }
                Console.WriteLine("");//separate rows
            }
            Console.WriteLine("\nSum of entire 2-d array");
            Console.WriteLine($"{sum}");

            for (a = 2; a < 3; a++)//3 row addition only
            {
                for (b = 0; b < 5; b++)
                {
                    sum1 += intArray[a, b];
                }
            }
            Console.WriteLine("Sum of row 3");
            Console.WriteLine($"{sum1}");

            for (c = 0; c < 5; c++)
            {
                for (d = 4; d < 5; d++)
                {
                    sum2 += intArray[c, d];
                }

            }
            Console.WriteLine("Sum of column 5");
            Console.WriteLine($"{sum2}");
        }
    }
}
