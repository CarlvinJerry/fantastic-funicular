using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            int index2 = 6;
            while (index <= 5)
            {
                Console.WriteLine("We're at index " + index);
                index++;

            }

            //A do while loop executes the comand inside the loop first before checking the condition
            do
            {
                Console.WriteLine(index2);
                index++;
            } while (index2 <= 5);
            
        }
    }
}
