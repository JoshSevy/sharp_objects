using System;

namespace sharp_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            // declaring a variable
            int num1;

            // assigning a value to a variable

            num1 = 23;

            // declaring and initializing a variable in one go

            int num2 = 23;
            int sum = num1 + num2;

            // Print to console using concatination

            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // doubles 

            double d1 = 3.1215;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine("d1 / d2 is " + dDiv);


            // Same example using floats

            float f1 = 3.1215f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            Console.WriteLine("f1 / f2 is " + fDiv);
            



            Console.Read();
        }
    }
}
