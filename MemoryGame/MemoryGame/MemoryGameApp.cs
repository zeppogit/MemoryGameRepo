using System;
using CodeLouisvilleLibrary;   // ALSO INHERITS FROM A CLASS IT CONTAINS 
using System;
using System.Collections.Generic;


namespace MemoryGame
{
	public class MemoryGameApp : CodeLouisvilleAppBase
	{
		public MemoryGameApp() : base("Memory Game")  // name in quotes provided to be implemented in Welcome()

			// may take parameter variable storing json filepath defined in Program.cs
		{
			// may take block of code instantiating object that property of a  list of possible words (taken from json)
			// creation of object would run deserializer


			//public MemoryGameApp(string saveFilePath) : base("Memory Game")
		}

        protected override bool Main()
        {

            int numberOfTurns = 0;
            int numberOfMatches = 0;

            /// THIS LING QUERY WILL GO INTO A DisplayGameBoard() method in GameBoard.cs class ////////////////////////
            /// 
            // The Three Parts of a LINQ Query:
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
            // PART 1. Data source.
            List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

            // The Three Parts of a LINQ Query:
            // PART 2. Query creation.
            Random r = new Random();   //System.Random()
            List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();
                // Take(16) not necessary until list becomes larger than 16,
                // where the parameter now shown as 16 will become an option selected by player before game board appears


            List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

            List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };


            Console.WriteLine(string.Join(", ", shuffledStr.ToArray()));  //FOR TESTING
            Console.WriteLine();  // FOR TESTING TO SHOW SHUFFLED WORDS AND ALLOW PICKING MATCHING NUMBERS
            //written to console for testing - in program, comment out previous line and uncomment the next line:
            //string.Join(", ", shuffledStr.ToArray());   //COMMENT THIS OUT WHEN TESTING AND UNCOMMENT PRIOR CONSOLE.WRITELINE


            // The Three Parts of a LINQ Query:
            // PART 3. Query execution.

            for (int i = 0; i < 13; i++, i++, i++, i++)
            {
                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
            }

    ////////////// END LINQ QUERY  ////// WILL BE MOVED
    

            // Game Board now displayed, and Game Play begins //////////////////////////////////////

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

            if (displayStr[choice1] == displayStr[choice2])
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
            return false;
        }
    }
}

