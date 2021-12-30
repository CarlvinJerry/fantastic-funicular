using System;

namespace DataTypes //Here we use different variables to store different values of unique types
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Learning c#"; //Double quotes
            char gender = 'M'; //Single quotes and only one single character
            int age = 27; //No quote, can be negative or positive
            double gpa = 10.8; //float(least accurate)...Use decimal for higher accuracy tasks
            bool isMale = true; //True or false

            Console.WriteLine("string"); //Constants are not srored in a variable
            Console.WriteLine(35); //Constants are not stored in a variable


            Console.ReadLine();
        }
    }


}
