using System;
using System.Collections.Generic;
using System.Linq;
using CodeLouisvilleLibrary;

namespace MemoryGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //THIS WILL CONTAIN THE RUN() INSTRUCTIONS FOR THE PROGRAM, NOT THE USER INTERFACE

            // use Run() from base class

            int numberOfTurns = 0;
            int numberOfMatches = 0;


            List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

            Random r = new Random();

            List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();  // Take(16) not necessary until list becomes larger than 16


            List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

            List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };


            //Console.WriteLine(string.Join(", ", shuffledStr.ToArray()));  //FOR TESTING
                //written to console for testing - in program, comment out previous line and uncomment the next line:
            string.Join(", ", shuffledStr.ToArray());   //COMMENT THIS OUT WHEN TESTING AND UNCOMMENT PRIOR CONSOLE.WRITELINE

           

            for (int i = 0; i < 13; i++, i++, i++, i++)
            {
                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i+1] + "    " + displayStr[i+2] + "    " + displayStr[i+3]);
                Console.WriteLine();
            }

            Console.WriteLine(" pick a number to reveal");

            int choice1 = -1 + Int32.Parse(Console.ReadLine());  // add code to prevent null?
            int compare1 = choice1;
            displayStr[choice1] = shuffledStr[choice1];



            for (int i = 0; i < 13; i++, i++, i++, i++)
            {

                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
            }

            Console.WriteLine(" pick another number to reveal");

            int choice2 = -1 + Int32.Parse(Console.ReadLine());   // add code to accept only numbers available on screen and  prevent null
            Console.WriteLine();
            //Console.Clear();
            displayStr[choice2] = shuffledStr[choice2];

            Console.Clear();
            for (int i = 0; i < 13; i++, i++, i++, i++)
            {

                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
            }


            numberOfTurns++; 

            if ( displayStr[choice1] == displayStr[choice2] )
            {
                numberOfMatches++;

                Console.WriteLine("A match!");
                Console.WriteLine($"That is match number {numberOfMatches}.");

                Console.WriteLine();
                if (numberOfMatches == 7)
                {
                    Console.Write("There is only one match left to reveal, so you have solved the puzzle on turn number {numberOfTurns}");
                }
            }
            else
            {
                Console.WriteLine("Not a match!   Try again.");
            }

        }

    }
}


