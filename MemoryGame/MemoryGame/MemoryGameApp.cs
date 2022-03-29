using System;
using CodeLouisvilleLibrary; 
using System;
using System.Collections.Generic;
using System.Linq;
using GameLibrary;

namespace MemoryGame
{
    public class MemoryGameApp : CodeLouisvilleAppBase
    {

        private static List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 ", " 17 ", " 18 ", " 19 ", " 20 ", " 21 ", " 22 ", " 23 ", " 24 ", " 25 ", " 26 ", " 27 ", " 28 ", " 29 ", " 30 ", " 31 ", " 32 ", " 33 ", " 34 ", " 35 ", " 36 " };

        private static List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 ", " 17 ", " 18 ", " 19 ", " 20 ", " 21 ", " 22 ", " 23 ", " 24 ", " 25 ", " 26 ", " 27 ", " 28 ", " 29 ", " 30 ", " 31 ", " 32 ", " 33 ", " 34 ", " 35 ", " 36 "};



        public MemoryGameApp() : base("Memory Game")  // name in quotes provided to be implemented in Welcome()
		{
		
		}


        protected override bool Main()
        {
            bool quit = false;

            var menu = new Menu<char>();

            menu.AddMenuItem('S', "Play small board");
            menu.AddMenuItem('L', "Play large board");
            menu.AddMenuItem('Q', "Quit");


            char menuSelection;
            bool validInput = false;


            if (validInput = TryPrompt4MenuItem<char>("\nPlease select one of the following options:", menu, out menuSelection, 5))
            { 
                switch (menuSelection)
                {
                    case 'S':
                        Words.CreateGameWords(8);
                        //Words.Words(8);
                        //Words.numWords = 8;
                        gamePlay(8);  //later:  gameplay(16)  16 squares 
                        break;
                    case 'L':
                        Words.CreateGameWords(18);
                        //Words.numWords = 18;
                        gamePlay(18); //36 squares
                        break;
                    case 'Q':
                        quit = true;
                        break;
                }
            }


            if (!validInput)
            {
                Console.WriteLine("\nSorry your input was not valid.");
                return quit;
            }

            return !quit;


        } // END MAIN



        private static void gamePlay(int num)
        {
            int numOfWords = num;
            int numberOfTurns = 0;
            int numberOfMatches = 0;

            bool validInput = false;

            while (numberOfMatches < (numOfWords - 1 ))
            {

                //createGameSolutionString(); // FOR TESTING
                //WaitForAnyKeyPress();     //  FOR TESTING

                displaySolution(numOfWords);  // UNCOMMENT this line and COMMENT OUT the next line FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                //Console.Clear();   // uncomment this for actual gameplay when done testing

                displayGameBoard(numOfWords);


                ///////////// Game Board now displayed, and Game Play begins //////////////////////////////////////


      ////////////////////////////  CHOICE 1  ///////////////////////////
      
                int choice1;
              
                if (validInput = TryPrompt4Integer(out choice1, "Pick a number on the board to reveal. (0 to Quit):  ", 4, 0, (numOfWords * 2)))
                // max tries 4 / min value accepted 0 / max value 16 if numOfWords is 8, otherwise 36
                {
                    if (choice1 == 0)
                    {
                        Console.WriteLine("Quitting.\n");
                        break;
                    }
                    else if (Words.shuffledStr[choice1 - 1] == " XX ")
                    {
                        Console.Clear();
                        Console.WriteLine("\nThat number is no longer on the board.  ");
                        WaitForAnyKeyPress();
                        Console.Clear();
                        continue;
                    }
                    else if (Words.shuffledStr[choice1 - 1] != " XX ")
                    {
                        Console.Clear();
                        displayStr[choice1 - 1] = Words.shuffledStr[choice1 - 1];
                    }
                }
                else if (!validInput)
                {
                    //Console.WriteLine();
                    Console.WriteLine("\nQuitting this game.  Too many failed attempts. \n\n");
                    break;
                }


                //displaySolution(numOfWords);  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                displayGameBoard(numOfWords);


     ////////////////////////////  CHOICE 2  ///////////////////////////
     
                int choice2;

                if (validInput = TryPrompt4Integer(out choice2, "\nPick another number on the board to reveal. (0 to Quit):  ", 4, 0, (numOfWords * 2))) ;
                // max tries 4 / min value accepted 0 / max value 16
                {
                    if (choice2 == 0)
                    {
                        Console.WriteLine("\nYou have quit this game.\n  ");
                        break;
                    }
                    if (Words.shuffledStr[choice2 - 1] == " XX ")
                    {
                        Console.Clear();
                        Console.WriteLine("\nThat number is no longer on the board.  What's the matter with you?  A wiseguy?");
                        displayStr[choice1 - 1] = numStr[choice1 - 1];
                        WaitForAnyKeyPress();
                        Console.Clear();
                        continue;  // turn will be evaluated as "Not a match!"
                    }

                    //                   else if ((choice2 == choice1) || (shuffledStrL[choice2 - 1] == " XX "))
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
                        displayStr[choice2 - 1] = Words.shuffledStr[choice2 - 1];
                    }
                }

     //////////////////// END CHOICES,  BEGIN EVALUATE TURN  /////////////////////////

                Console.Clear();

                numberOfTurns++;

                if ((displayStr[choice1 - 1] == displayStr[choice2 - 1]) && (choice2 != choice1))
                {
                    numberOfMatches++;

                    displayGameBoard(numOfWords);


                    Console.Clear();
                    Console.WriteLine("\nA match!");
                    Console.WriteLine($"That is match number {numberOfMatches}.");
                    WaitForAnyKeyPress();
                    Console.Clear();

                    // SET STRING VALUES OF MATCHES TO ASSIST TESTING FUTURE ATTEMPTS TO SELECT THEM AGAIN
                    Words.shuffledStr[choice1 - 1] = " XX ";
                    Words.shuffledStr[choice2 - 1] = " XX ";

                    Console.WriteLine();



                    if (numberOfMatches == (numOfWords - 1))
                    {
                        Console.Clear();
                        displayGameBoard(numOfWords);

                        Console.Write($"There is only one match left to reveal, so you have completed the game on turn number {numberOfTurns}.\n\n");

                    }
                }

                //else if ((choice2 == choice1) || (shuffledStrL[choice2 - 1] == " XX "))
                else
                {
                    Console.Clear();
                    displayGameBoard(numOfWords);
                    Console.WriteLine("Not a match!");
                    WaitForAnyKeyPress();
                    Console.Clear();
                    displayStr[choice1 - 1] = numStr[choice1 - 1];
                    displayStr[choice2 - 1] = numStr[choice2 - 1];
                }

            } // END WHILE LOOP

        }


        private static void WaitForAnyKeyPress()
        {
            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey(true);
        }



        private static void displayGameBoard(int num)
        {
            Console.WriteLine();
            if (num == 8)
            {
                for (int i = 0; i < 13; i += 4)
                {
                    Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
                    Console.WriteLine();

                }
            }
            if (num == 18)
            {
                for (int i = 0; i < 31; i += 6)
                {
                    Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3] + "    " + displayStr[i + 4] + "    " + displayStr[i + 5]);
                    Console.WriteLine();

                }
            }
        }

//////////////////// FUNCTIONS TO ASSIST WITH  TESTING APP  ///////////////////////////////////////////////

        private static void displaySolution(int num)  //FOR USE IN TESTING - DISPLAY ALL THE GAME WORDS ON THE GAMEBOARD
        {
            Console.WriteLine();

            if (num == 8)
            {
                for (int i = 0; i < 13; i += 4)
                {
                    Console.WriteLine("    " + Words.shuffledStr[i] + "    " + Words.shuffledStr[i + 1] + "    " + Words.shuffledStr[i + 2] + "    " + Words.shuffledStr[i + 3]);
                    Console.WriteLine();
                }
            }
            if (num == 18)
            {
                for (int i = 0; i < 31; i += 6)
                {
                    Console.WriteLine("    " + Words.shuffledStr[i] + "    " + Words.shuffledStr[i + 1] + "    " + Words.shuffledStr[i + 2] + "    " + Words.shuffledStr[i + 3] + "    " + Words.shuffledStr[i + 4] + "    " + Words.shuffledStr[i + 5]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("SOLUTION DISPLAYED ABOVE FOR TESTING USE\n");
        }


        private static void createGameSolutionString()  //FOR USE IN TESTING - DISPLAY ALL THE GAME WORDS IN A STRING
        {
            Console.WriteLine();
            Console.WriteLine("TEST NOTE: Here are the words used");
            Console.WriteLine(string.Join(", ", Words.shuffledStr.ToArray()));
            Console.WriteLine();
        }
    }
}

