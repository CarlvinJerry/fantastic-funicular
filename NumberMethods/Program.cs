using System;

namespace NumberMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(-5.763);
            Console.WriteLine(-5.763 + 8);
            Console.WriteLine(-5.763-10);
            Console.WriteLine(-5.763/6);
            Console.WriteLine(-5.763*3);
            Console.WriteLine(5%2); //Modulus
            Console.WriteLine(4 + 2 * 3); //bodmas
            Console.WriteLine((4 + 2) * 3); //ignore bodmas
            Console.WriteLine(5.0 + 8.1); //decimal output
            Console.WriteLine(4 + 2.1); // Decimal output
            Console.WriteLine(5 / 2); //Integer
            Console.WriteLine(5/2.0); // decimal
            int number = 6;
            number++; //this will add a value to number variable
            number--;
            Console.WriteLine(number);

            //Math operations using methods------
            Console.WriteLine(Math.Pow(number,2));
            Console.WriteLine(Math.Sqrt(Math.Pow(number, 2)));
            Console.WriteLine(Math.Round(number*2.45,1));


        }
    }
}
