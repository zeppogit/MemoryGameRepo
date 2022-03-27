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

            bool validInput = false;

            while (numberOfMatches < 7)
            {

                displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY

                displayGameBoard();


                ///////////// Game Board now displayed, and Game Play begins //////////////////////////////////////

                int choice1;
                if (validInput = TryPrompt4Integer(out choice1, "Pick a number on the board to reveal. (0 to Quit):  ", 4, 0, 16))
                    // max tries 4 / min value accepted 0 / max value 16
                {
                    if (choice1 == 0)
                    {
                        break;
                    }
                    else if (shuffledStr[choice1 - 1] == " XX ")
                    {
                        Console.Clear();
                        Console.WriteLine("\nThat number is no longer on the board.  ");
                        WaitForAnyKeyPress();
                        Console.Clear();
                        continue;
                    }
                    else if (shuffledStr[choice1 - 1] != " XX ")
                    {
                        Console.WriteLine("\nTEST - INPUT NOT 0 OR A NUMBER ALREADY OFF THE BOARD\n");
                        displayStr[choice1 - 1] = shuffledStr[choice1 - 1];
                    }
                }

                Console.Clear();

                //displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                displayGameBoard();

                /////////////////
                int choice2;

                if (validInput = TryPrompt4Integer(out choice2, "\nPick another number on the board to reveal. (0 to Quit):  ", 4, 0, 16));
                     // max tries 4 / min value accepted 0 / max value 16
                {
                    if (choice2 == 0)
                    {
                        Console.WriteLine("\nYou have quit this game.\n  ");
                        break;
                    }
                    if (shuffledStr[choice2 - 1] == " XX ")
                    {
                        Console.Clear();
                        Console.WriteLine("\nThat number is no longer on the board.  What's the matter with you?  A wiseguy?");
                        displayStr[choice1 - 1] = numStr[choice1 - 1];
                        WaitForAnyKeyPress();
                        Console.Clear();
                        continue;
                    }

//                   else if ((choice2 == choice1) || (shuffledStr[choice2 - 1] == " XX "))
                    else if (choice2 == choice1)
                    {
                        Console.Clear();
                        Console.WriteLine("\nThat is the same number as your first choice.  ");
                        displayStr[choice1 - 1] = numStr[choice1 - 1];
                        displayStr[choice2 - 1] = numStr[choice2 - 1];
                        WaitForAnyKeyPress();
                        Console.Clear();
 
                    }
                    if (choice2 != choice1)
                    {
                        displayStr[choice2 - 1] = shuffledStr[choice2 - 1];
                    }
                }

                //////////////////// END CHOICES,  BEGIN COMPARISON

                Console.Clear();
                //displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY

  //              displayGameBoard();
 //               Console.WriteLine("WAIT HERE BEFORE COMPARISON OF CHOICE 1 AND 2 DISPLAY STRINGS");
  //              WaitForAnyKeyPress();

                numberOfTurns++;

                if ( (displayStr[choice1 - 1] == displayStr[choice2 - 1] )  && (choice2 != choice1))
                {
                    numberOfMatches++;

                    displayGameBoard();


                    Console.Clear();
                    Console.WriteLine("\nA match!");
                    Console.WriteLine($"That is match number {numberOfMatches}.");
                    WaitForAnyKeyPress();
                    Console.Clear();
                    ////////////////////////////////////////////////////////////////
                    //Console.WriteLine($"Choice 1 was {choice1}\n\n");

                    shuffledStr[choice1 - 1] = " XX ";
                    shuffledStr[choice2 - 1] = " XX ";

                    //displaySolution();
                    Console.WriteLine();
                    ////////////////////////////////////////////////////////////////


                    if (numberOfMatches == 7)
                    {
                        Console.Clear();
                        displayGameBoard();

                        Console.Write($"There is only one match left to reveal, so you have solved the puzzle on turn number {numberOfTurns}.  \n");
 
                    }
                }
                
                //else if ((choice2 == choice1) || (shuffledStr[choice2 - 1] == " XX "))
                else
                {
                    Console.Clear();
                    displayGameBoard();
                    Console.WriteLine("Not a match!");
                    WaitForAnyKeyPress();
                    Console.Clear();
                    displayStr[choice1 - 1] = numStr[choice1 - 1];
                    displayStr[choice2 - 1] = numStr[choice2 - 1];
                }

            } // END WHILE

            Console.WriteLine("\nWould you like to play a new round?  Enter Y for yes, or N  to quit the program.");
            Console.ReadLine();  // put this in Prompt4YOrN method with return options

            Console.Clear();
            return true;

        } // END MAIN


        private static void WaitForAnyKeyPress()
        {
            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey(true);
        }



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

