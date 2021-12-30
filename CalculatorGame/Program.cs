using System;

namespace CalculatorGame 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take two integer numbers from user and sum them.
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
    }
}
