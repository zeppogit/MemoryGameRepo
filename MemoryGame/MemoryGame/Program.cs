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


            List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

            Random r = new Random();

            List<string> random5 = words.OrderBy(w => r.Next()).Take(16).ToList();  // Take(16) not necessary until list becomes larger than 16


            List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

            List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

            for (int i = 0; i < 13; i++, i++, i++, i++)
            {
                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i+1] + "    " + displayStr[i+2] + "    " + displayStr[i+3]);
                Console.WriteLine();
            }

            Console.WriteLine(" pick a number to reveal");

            int choice1 = -1 + Int32.Parse(Console.ReadLine());  // add code to prevent null?
            int compare1 = choice1;
            displayStr[choice1] = words[choice1];

            for (int i = 0; i < 13; i++, i++, i++, i++)
            {

                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
            }

            Console.WriteLine(" pick another number to reveal");

            int choice2 = -1 + Int32.Parse(Console.ReadLine());   // add code to accept only numbers available on screen and  prevent null
            Console.WriteLine();
            //Console.Clear();
            displayStr[choice2] = words[choice2];

            Console.Clear();
            for (int i = 0; i < 13; i++, i++, i++, i++)
            {

                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
            }

            if (choice1 == choice2)
            {
                Console.WriteLine("A match!");
            }
            else
            {
                Console.WriteLine("Not a match!   Try again.");
            }

        }

    }
}


