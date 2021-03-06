﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a Loop that prints all values from 1-255
            for (int i=1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i=1; i<=100; i++)
            {
                if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i=1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

            } 
            
            // If you used modulus in the last step, try doing the same without using it. Vice-versa for those who didn't!
            int counter_3 = 3;
            int counter_5 = 5;
            for (int i = 15; i >= 0; i--)
            {
                counter_3 -= 1;
                counter_5 -= 1;
                if (counter_3 == 0 && counter_5 == 0)
                {
                    counter_3 = 3;
                    counter_5 = 5;
                    Console.WriteLine("/FizzBuzz");

                }

                if (counter_3 == 0)
                {
                    counter_3 = 3;
                    Console.WriteLine("/Fizz");
                }

                if (counter_5 == 0)
                {
                    counter_5 = 5;
                    Console.WriteLine("/Buzz");
                }
            }
            // Generate 10 random values and output the respective word, in relation to step three, for the generated values
            Random rand = new Random();
            for (int i = 0; i <= 10; i++)
            {
                // Console.WriteLine(rand.Next(1,10));
                if(rand.Next(1, 10) % 3 == 0 && rand.Next(1, 10) % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                if(rand.Next(1, 10) % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                if(rand.Next(1, 10) % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
