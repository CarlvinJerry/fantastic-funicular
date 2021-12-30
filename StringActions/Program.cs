using System;

namespace StringActions //Here we look at the different methods/functions we can apply to strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giraffe Academy"); //plain text representation
            Console.WriteLine("Girrafe\nAcademy"); //prints a new line
            Console.WriteLine("Girrafe\"Academy\""); // Here I want to print the quotation marks as part fot the string
            string phrase = "Girrafe Academy"; // storing a string in a variable
            string concatination = phrase + "is cool"; //concatinating strings
            Console.WriteLine(concatination);
            Console.WriteLine(concatination.Length); //count length of a string
            Console.WriteLine( phrase.ToUpper()); //apply method to convert string to upper case
            Console.WriteLine(phrase.Contains("Academy")); //True
            Console.WriteLine(phrase.Contains("Academyz")); //False
            Console.WriteLine(phrase[0]);//access individual characters by index(G)
            Console.WriteLine(phrase.IndexOf(" ")); //gets the index of a character if present in string
            Console.WriteLine(phrase.Substring(8)); //substrings from the index position
            Console.WriteLine(phrase.Substring(8,4)); //substrings from the index position with number of characters following
        }
    }
}
