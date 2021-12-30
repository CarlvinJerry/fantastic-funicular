using System;

namespace Arrays //Allow us to store multipple values unlike in variables, in the same container
//- A coolection of variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4,8,15,15,23,42 }; //An array of integers

            //Accessing values inside an array
            //Console.WriteLine(luckyNumbers[0]);

            //Updating elements in an array
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            //Array of strings
            string[] pals = new string[5]; //creates an empty array of known number of values
            pals[0] = "Jim";
            pals[1] = "Kelly";
            Console.WriteLine(pals[1]);
        }
    }
}
