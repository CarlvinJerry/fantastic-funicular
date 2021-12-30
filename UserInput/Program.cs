using System;

namespace UserInput //Allows the program to interact with the users
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for their name and say hi to them
            Console.Write("Enter your name: "); // prints without going to a new line
            string name = Console.ReadLine(); //pauses the program and waits for text to be entered and stores to a variable
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello there " + name + ", congratulations on turning " + age);
        }
    }
}
