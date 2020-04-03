using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            var numbers = new List<int>();

            //Create a variable of type int with an initializer of 0
            int a = 0;


            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                a++;
                // Then add your variable to "numbers"
                numbers.Add(a);

            } while (a < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while(a < 200)
            {
                // Increment your variable by 1
                a++;
                // Then add your variable to "numbers"
                numbers.Add(a);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(a = 199; a <= numbers.Count && a>= 0; a--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers[a]);
            }
        }
    }
}
