using System;

namespace ForLoops //These loops allow us to keep track of iterating variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
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


            //Lucky numbers
            for (int i = 0; i < luckuNumbers.Length; i++)
            {
                Console.WriteLine(luckuNumbers[i]);
                
            }
        }


        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }



            return result;
        }
    }
}
