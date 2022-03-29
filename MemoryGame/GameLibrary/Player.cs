﻿using System;
namespace GameLibrary
{
	public class Player
	{
		public Player()
		{
		}
	}
}

/////////////// BELOW:  TEMPORARY SAVE OF MemoryGameApp.cs before adding functionality of large gameboard option and Words.cd  /////////////////

/*
using System;
using CodeLouisvilleLibrary; 
using System;
using System.Collections.Generic;
using System.Linq;


namespace MemoryGame
{
	public class MemoryGameApp : CodeLouisvilleAppBase
	{

        protected static int numOfWords;

        private static List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

        private static List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

        //private static List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

        private static List<string> wordSource = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "DOOR", "BOAT", "CARS", "ROAD", "HOME", "FOAM", "TRIP", "HARP", "MEAT", "FOOT", "FEET", "PALM", "OATS", "TEAM", "LOOP", "POOL", "HEAD", "JEEP", "COAT", "STOP", "PORT", "NICE", "COMB", "EASY", "GRID", "ICEY", "JOKE", "KNOT", "LICE", "MOAT", "NOTE", "OXEN", "QUAY", "RACE", "ROPE", "SAND", "VINE", "VOTE", "WHIP", "WEED", "EXIT", "YEAR", "DUNE", "YELP", "ZOOM"};

        private static Random r = new Random();


        private static List<string> shuffledStr = wordSource.OrderBy(w => r.Next()).Take(numOfWords).ToList();

        foreach (word in shuffledStr)
        {
            shuffledStr.Append(word);
        }


       // private static List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();




        public MemoryGameApp() : base("Memory Game")  // name in quotes provided to be implemented in Welcome()
		{
		
		}



        protected override bool Main()
        {
            bool quit = false;

            //int numOfWords;  

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
                        numOfWords = 8;
                        gamePlay();  //later:  gameplay(16)  16 squares 
                        break;
                    case 'L':
                        numOfWords = 18;
                        gamePlay();   //gamePlay(36) etc //36 squares
                        //Console.WriteLine("\nWHOOOOPS!!!!  TEST CODE\n");
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



        private static void gamePlay()
        {

            int numberOfTurns = 0;
            int numberOfMatches = 0;

            bool validInput = false;

            while (numberOfMatches < 7)
            {

                displaySolution(numOfWords);  // UNCOMMENT this line and COMMENT OUT the next line FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                //Console.Clear();   // uncomment this for actual gameplay when done testing

                displayGameBoard(numOfWords);


                ///////////// Game Board now displayed, and Game Play begins //////////////////////////////////////


      ////////////////////////////  CHOICE 1  ///////////////////////////
      
                int choice1;
                if (validInput = TryPrompt4Integer(out choice1, "Pick a number on the board to reveal. (0 to Quit):  ", 4, 0, 16))
                // max tries 4 / min value accepted 0 / max value 16
                {
                    if (choice1 == 0)
                    {
                        Console.WriteLine("Quitting.\n");
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
                        Console.Clear();
                        displayStr[choice1 - 1] = shuffledStr[choice1 - 1];
                    }
                }
                else if (!validInput)
                {
                    //Console.WriteLine();
                    Console.WriteLine("\nQuitting this game.  Too many failed attempts. \n\n");
                    break;
                }


                //displaySolution();  // UNCOMMENT FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY
                displayGameBoard(numOfWords);


     ////////////////////////////  CHOICE 2  ///////////////////////////
     
                int choice2;

                if (validInput = TryPrompt4Integer(out choice2, "\nPick another number on the board to reveal. (0 to Quit):  ", 4, 0, 16)) ;
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
                        continue;  // turn will be evaluated as "Not a match!"
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
                    shuffledStr[choice1 - 1] = " XX ";
                    shuffledStr[choice2 - 1] = " XX ";

                    Console.WriteLine();



                    if (numberOfMatches == 7)
                    {
                        Console.Clear();
                        displayGameBoard(numOfWords);

                        Console.Write($"There is only one match left to reveal, so you have completed the game on turn number {numberOfTurns}.\n\n");

                    }
                }

                //else if ((choice2 == choice1) || (shuffledStr[choice2 - 1] == " XX "))
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
            else
                for (int i = 0; i < 25; i += 6)
                {
                    Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]) + "    " + displayStr[i + 4] + "    " + displayStr[i + 5]);
                    Console.WriteLine();

                }
        }


        private static void displaySolution(int num)  //FOR USE IN TESTING
        {
            if (num == 8)
            {
                for (int i = 0; i < 13; i += 4)
                {
                    Console.WriteLine("    " + shuffledStr[i] + "    " + shuffledStr[i + 1] + "    " + shuffledStr[i + 2] + "    " + shuffledStr[i + 3]);
                    Console.WriteLine();
                }
            }
            else if (num == 18)
            {
                for (int i = 0; i < 25; i += 6)
                {
                    Console.WriteLine("    " + shuffledStr[i] + "    " + shuffledStr[i + 1] + "    " + shuffledStr[i + 2] + "    " + shuffledStr[i + 3] + "    " + shuffledStr[i + 4] + "    " + shuffledStr[i + 5]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("SOLUTION DISPLAYED ABOVE FOR TESTING USE\n");

        }

        ///////// CAN USE FOR TESTING TO VIEW FULL DATA SOURCE INSTEAD A GAME BOARD DISPLAY:  

        //private void createGameSolutionString()
        //{
        //    Console.WriteLine(string.Join(", ", shuffledStr.ToArray()));
        //    Console.WriteLine();
        //}
    }
}

*/




