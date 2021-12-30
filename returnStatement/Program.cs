using System;

namespace returnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = GetCube(5);
            Console.WriteLine(GetCube(3));
            Console.WriteLine(cubedNumber);
        }

        static int GetCube(int number) //the return value or type is specified before the method name
        {
            int result = number * number * number;
            return result;
        }
    }
}
