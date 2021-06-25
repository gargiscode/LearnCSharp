using System;
using System.Collections.Generic;

namespace CSharpProject
{
    public
    class Program
    {
       
        static void Main(string[] args)
        {

            string entry = FetchUserEntry();
 
            switch (entry)
            {
                case "1":
                    {
                        // String Operations
                        Console.WriteLine("Demonstrating Trim() operations .....");
                        //Console.WriteLine("Initial String");
                        string greeting = "      There are spaces everywhere!       ";
                        Console.WriteLine($"Initial String is --->  [{greeting}]");

                        string trimmedGreeting = greeting.TrimStart();
                        Console.Write("After TrimStart() --->  ");
                        Console.WriteLine($"[{trimmedGreeting}]");

                        trimmedGreeting = greeting.TrimEnd();
                        Console.Write("After TrimEnd() --->  ");
                        Console.WriteLine($"[{trimmedGreeting}]");

                        trimmedGreeting = greeting.Trim().Replace("everywhere", "nowhere");
                        Console.Write("After Replace() --->  ");
                        Console.WriteLine($"[{trimmedGreeting}]");


                        //String search
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Demonstrating string search operations .....");
                        
                        string songLyrics = "You say goodbye, and I say hello";
                        Console.WriteLine($"The input string is ---> [{songLyrics}]");

                        if (songLyrics.StartsWith("You"))
                            Console.WriteLine("[This sentence starts with You]");
                        else
                            Console.WriteLine("[This sentence does not start with You]");

                        if (songLyrics.EndsWith("hello"))
                            Console.WriteLine("[This sentence ends with hello]");
                        else
                            Console.WriteLine("[This sentence does not end with hello]");

                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.WriteLine("Press 2 to continue to the next demonstration or press * to go back to menu");
                        //choice = Console.ReadLine();

                        break;
                    }

                case "2":
                    {
                        //Integer precision and limits
                        Console.WriteLine("Demonstrating Integer precision and limits ....");
                                                
                        int a = 7;
                        int b = 4;
                        int c = 3;
                        int d = (a + b) / c;
                        int e = (a + b) % c;
                        Console.WriteLine($"{a+b} divided by {c} equals {d}");
                        Console.WriteLine($"quotient: {d}");
                        Console.WriteLine($"remainder: {e}");

                        Console.WriteLine();
                        Console.WriteLine();

                        //Integer limits
                        
                        int max = int.MaxValue;
                        int min = int.MinValue;
                        Console.WriteLine($"The range of integers is {min} to {max}");
                        int what = max + 3;
                        int whatElse = min + 2;
                        Console.WriteLine($"An example of overflow: MaxLimit + 3 = {what}");
                        Console.WriteLine($"An example of overflow: MinLimit + 2 = {whatElse}");
                        Console.WriteLine();
                        Console.WriteLine();

                        //Working with double type
                        Console.WriteLine("Demonstrating double and decimal data types ....");

                        double ad = 5;
                        double bd = 4;
                        double cd = 2;
                        double dd = (ad + bd) / cd;
                        Console.WriteLine(dd);
                        Console.WriteLine($"{ad + bd} divided by {cd} equals:");
                        Console.WriteLine();
                        Console.WriteLine();

                        //Double type precision
                        double maxd = double.MaxValue;
                        double mind = double.MinValue;
                        Console.WriteLine($"The range of double is {mind} to {maxd}");
                        double third = 1.0 / 3.0;
                        Console.WriteLine(third);
                        Console.WriteLine();
                        Console.WriteLine();

                        //Decimal Type
                        double i = 1.0;
                        double f = 3.0;
                        Console.WriteLine(i / f);

                        decimal g = 1.0M;
                        decimal h = 3.0M;
                        Console.WriteLine(g / h);
                        Console.WriteLine($"The range of double is {decimal.MinValue} to {decimal.MaxValue}");
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("Demonstrating use of special Math functions ....");
                        //Using Math.PI and Math.Pow
                        
                        double radius = 2.83;
                        double area = Math.PI * Math.Pow(radius, 2.0);
                        Console.WriteLine($"The value of pi is {Math.PI}");
                        Console.WriteLine($"The value of {radius} raised to the power of 2 is {Math.Pow(radius, 2.0)}");
                        Console.WriteLine($"The area of a circle of radius {radius} is {area}");

                        break;
                    }

                case "4":
                    {
                        //For loop to generate a matrix
                        Console.WriteLine("Demonstrating use of for loop to write the alphabet in a grid .....");

                        //int row = 0;
                        char column = 'a';

                       while (column <= 'z')
                        {
                            for (int row = 0; row < 6 && column<= 'z'; row++)
                            {
                                if (column > 'z')
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write(column);
                                    column++;
                                }
                            }
                            Console.WriteLine();
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine(); 
                        Console.WriteLine();
                        //Sum of all integers that are divisible by 4
                        Console.WriteLine("Demonstrating use of for loop to calculate sum ......");
                        int sum = 0;
                        int number;
                        for (number = 1; number < 21; number++)
                        {
                            if (number % 4 == 0)
                            {
                                Console.Write($" {number} +");
                                sum = sum + number;
                            }
                        }
                        Console.WriteLine("Sum of all multiples of 4 less than 21 is {sum}");
 
                        break;
                    }

                case "5":
                    {
                        //Modify List
                        Console.WriteLine("Demonstrating use of Lists ....");
                        var cities = new List<string> { "Washington", "Michigan", "North Carolina" };
                        Console.WriteLine($"I have visited: ");
                        foreach (var city in cities)
                        {
                            Console.WriteLine($" {city.ToUpper()}!");
                        }

                      
                        Console.WriteLine();
                        cities.Add("California");
                        cities.Add("Wyoming");
                        Console.WriteLine($"I have removed {cities[0].ToUpper()} beacuse of course I live here ;-)");
                        cities.Remove("Washington");
                        Console.WriteLine($"I have added {cities[2].ToUpper()} and {cities[3].ToUpper()} to the list.");
                        
                        foreach (var city in cities)
                        {
                            Console.WriteLine($" {city.ToUpper()}!");
                        }
                        
                        Console.WriteLine($"Now the list has {cities.Count} states in it");
                        

                        //// Search and Sort lists
                        //var twister = new List<string> { "How", "much", "wood", "could", "a", "wood", "chuck", "chuck", "if", "a", "wood", "chuck", "could", "chuck", "wood?" };
                        //var index = twister.IndexOf("wood");
                        //if (index != -1)
                        //    Console.WriteLine($"The word {twister[index]} is at index {index}");

                        //var notFound = twister.IndexOf("Not Found");
                        //Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

                        //twister.Sort();
                        //foreach (var word in twister)
                        //{
                        //    Console.WriteLine(word);
                        //}

                        //// 
                        break;
                    }

            }

        }
        private static string FetchUserEntry()
        {
            string userChoice = "";

            do
            {
                if (userChoice.Length != 1)
                {
                    Console.WriteLine("Valid inputs are the digits from 1 to 7. Please try again.");
                }
                Console.WriteLine("1. Press 1 for String Operations: ");
                Console.WriteLine("2. Press 2 for different Data Types: ");
                Console.WriteLine("3. Press 3 for Special Math Functions: ");
                Console.WriteLine("4. Press 4 for Branches and Loops: ");
                Console.WriteLine("5. Press 5 for Colelctions: ");
                userChoice = Console.ReadLine();
            }
            while (userChoice.Length > 1);

            return userChoice;
        }
    }
}
