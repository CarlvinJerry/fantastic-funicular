using System;

namespace _2dArrays //two dimesional arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };

            //Accessing elelements in array...row i, col j
            Console.WriteLine(numberGrid[1, 1]);
        }
    }
}
