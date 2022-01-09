using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e) { 
                Console.WriteLine(e.Message); //Avoid exception e to print out custome error messages

            }
            //catch (FormatException e)// Use specific exception types to only catch specific error types ie, FormatExceptio, DivideByZero Execption
            //{
            //    Console.WriteLine(e.Message); //Avoid exception e to print out custome error messages

            //}
            finally //this code gets executed no matter what error happens
            {

            }



        }
    }
}
