using System;

namespace ExponentMethods //Exponent functions that can take a base no and power number and power it
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(5,4));
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i=0; i < powNum; i++)
            {
                result = result * baseNum;
            }



            return result;
        }
    }
}
