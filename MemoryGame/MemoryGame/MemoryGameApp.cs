using System;
using CodeLouisvilleLibrary;   // ALSO INHERITS FROM A CLASS IT CONTAINS 
using System;
using System.Collections.Generic;


namespace MemoryGame
{
	public class MemoryGameApp : CodeLouisvilleAppBase
	{

        protected List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

        protected List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

        /// THIS LING QUERY WILL GO INTO A DisplayGameBoard() method in GameBoard.cs class ////////////////////////
        /// 
        // The Three Parts of a LINQ Query:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
        // PART 1. Data source:

        protected static List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

        // The Three Parts of a LINQ Query:
        // PART 2. Query creation:

        protected static Random r = new Random();   //System.Random()
        protected static List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();
            // Take(16) not necessary until list becomes larger than 16,
            // where the parameter now shown as 16 will become an option selected by player before game board appears

     

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


            while (numberOfMatches < 7)
            {

                //displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY

                displayGameBoard();


                // Game Board now displayed, and Game Play begins //////////////////////////////////////

                Console.WriteLine("Pick a number to reveal. (Q to Quit)");

                int choice1 = -1 + Int32.Parse(Console.ReadLine());  // add code to prevent null?
                int compare1 = choice1;
                displayStr[choice1] = shuffledStr[choice1];


                Console.Clear();

                displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                displayGameBoard();


                Console.WriteLine("Pick another number to reveal. (Q to Quit)");

                int choice2 = -1 + Int32.Parse(Console.ReadLine());   // add code to accept only numbers available on screen and  prevent null
                Console.WriteLine();
                displayStr[choice2] = shuffledStr[choice2];

                Console.Clear();
                displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY

                displayGameBoard();


                numberOfTurns++;

                if (displayStr[choice1] == displayStr[choice2])
                {
                    numberOfMatches++;

                    displayGameBoard();


                    Console.Clear();
                    Console.WriteLine("A match!");
                    Console.WriteLine($"That is match number {numberOfMatches}.");
                    // create a prompt function "press Y to continue or Q to quit"  etc
                    //   where if Y, a Console.Clear() runs.


                    //Console.WriteLine();
                    if (numberOfMatches == 7)
                    {
                        Console.Clear();

                        displayGameBoard();


                        Console.Write($"There is only one match left to reveal, so you have solved the puzzle on turn number {numberOfTurns}.  ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Clear();
                    displayGameBoard();  // ADD DISPLAY FUNCTION HERE
                    Console.WriteLine("Not a match!");

                    // ADD MENU TO PRESS Y TO CONTINUE OR N TO QUIT   OR... JUST MENTION OPTION TO PRESS Q TO QUIT
                    //Console.Clear();

                    //
                    displayStr[choice1] = numStr[choice1];
                    displayStr[choice2] = numStr[choice2];
                }

            } // END WHILE
            
            Console.WriteLine("Would you like to play a new game?  Enter Y for yes, or N  to quit the program.");
            Console.ReadLine();  // put this in Prompt4YOrN method with return options

            Console.Clear();
            return true;

        } // END MAIN


        private void displayGameBoard()
        {
            Console.WriteLine();

            for (int i = 0; i < 13; i++, i++, i++, i++)
            {
                Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                Console.WriteLine();
                
            }
        }


        private void displaySolution()  //FOR USE IN TESTING
        {
            for (int i = 0; i < 13; i++, i++, i++, i++)
            {
                Console.WriteLine("    " + shuffledStr[i] + "    " + shuffledStr[i + 1] + "    " + shuffledStr[i + 2] + "    " + shuffledStr[i + 3]);
                Console.WriteLine();  

            }
        }

        ///* CAN USE FOR TESTING INSTEAD A GAME BOARD DISPLAY*/
        //private void createGameSolutionString()
        //{
        //    Console.WriteLine(string.Join(", ", shuffledStr.ToArray()));
        //    Console.WriteLine();
        //}
    }
}

