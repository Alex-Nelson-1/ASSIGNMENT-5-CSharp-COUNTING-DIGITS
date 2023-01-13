// Created by: Alex Nelson
// Created on: Jan 2022
//
// This program tells you which age range of movies you can
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Explanation of the algorithm
        Console.WriteLine("This program will count the number of digits in positve numbers(excluding decimals. It also excludes numbers with digits bigger than 19 due to a technicallity with c#). If zero starts your number it does not count as a digit.");
        Console.WriteLine("");
        //Input for user’s number
        Console.WriteLine("Please enter your number");
        decimal number = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("");
        int counter = 0;
        //Process: Function to check the amount of digits in any postive whole number(except 1)
        if (number > 0)
        {
            while (number >= 1)
            {
                number = number / 10;
                counter = counter + 1;
            }
        }
        Console.WriteLine(counter);
        Console.WriteLine("\nDone");
    }
}
