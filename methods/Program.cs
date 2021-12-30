using System;

namespace methods //Function to perform specific tasks
{
    class Program
    {
        static void Main(string[] args) //the main method is executed first
        {   
            
            Console.WriteLine("Hello World!");
            SayHello("Carlvin", 33);
            SayHello("Mwange", 45);
            SayHello("Jerry",56);
        }

        //Create a method to say hi to the user, we have to call in inside the Main method for it to run
        static void SayHello(string name, int age) 
        {
            Console.WriteLine("Hello " + name + " you're " + age );
        }

    }
}
