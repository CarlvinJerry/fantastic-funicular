using System;

namespace Variables //-Variables are containers to store values in
{
    class Program
    {
        static void Main(string[] args) //A function or method to do something
        {
            string characterName = "Carlvin";
            int characterAge; //int characterAge = 27; Option 1-- Option 2 - declare the variable then assign value after
            characterAge = 27;
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge +" years old"); //Concatenating
            Console.WriteLine("But he didn't like being " + characterAge + " years old"); //Concatenating
            characterName = "Mwange"; //You can update a variable value halfway through the program
            Console.WriteLine("He however preferred the name " + characterName);
        }
    }
}
