using System;

namespace ifStatements //conditional statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if(isMale&&isTall)
            {
                Console.WriteLine("You're a tall male");

            } else if (isMale && !isTall)//! negation operatior for 'not'
            {
                Console.WriteLine("You're a short male");
            }else if (!isMale && isTall)
            {
                Console.WriteLine("You're not a male but you're tall");
            }
            else
            {
                Console.WriteLine("You're not male and not tall");
            }

            //if (isMale || isTall) //or
            //{
            //    Console.WriteLine("You're a tall male");

            //}
            //else
            //{
            //    Console.WriteLine("You're either not male or not tall or both");
            //}

            //Comparison if statements
            Console.WriteLine(GetMax1(20, 10));

            Console.WriteLine(GetMax2(20, 10, 30));

        }

        static int GetMax1(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1; // Console.WriteLine("The maximum value is " + num1);
            }
            else
            {
                result = num2; // Console.WriteLine("The maximum value is " + num2);
            }

            return result;
        }

        static int GetMax2(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1; // Console.WriteLine("The maximum value is " + num1);
            }
            else if (num2 >=num1 && num2 >= num3)
            {
                result = num2; // Console.WriteLine("The maximum value is " + num2);
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}


