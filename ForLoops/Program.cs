using System;

namespace ForLoops //These loops allow us to keep track of iterating variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while(i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            int[] luckuNumbers = { 4, 6, 7, 8, 15, 23, 42 }; //An array of ints

            for (int i = 1; i <=5; i++)//requires three things unlike while loop: variable intitalization;loop condition;the exec action in the for loop
            {
                Console.WriteLine(i);
            }


            //Lucku numbers
            for (int i = 0; i < luckuNumbers.Length; i++)
            {
                Console.WriteLine(luckuNumbers[i]);
                
            }
        }
    }
}
