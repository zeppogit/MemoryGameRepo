## MemoryGame  - Code Louisville SQL class project


# Introduction
This repository is for my Code Louisville Winter 2022 C# course project. 


# Description

Classic memory testing game similar to Classic Concentration single player with the most basic of rules.  Object is to uncover all the matching words on the board in as few turns as you can, relying on memory to help you make matches.


## Technical Instructions

For testing purposes, in MemoryGameApp.cs it is advised to uncomment line 85, which for normal game play shows as:

      //DisplaySolution(numOfWords);  // UNCOMMENT this line and COMMENT OUT the next line FOR TESTING  // COMMENT OUT FOR ACTUAL GAME PLAY

and comment out line 86 which in normal game play shows as:

      Console.Clear();   // uncomment this for actual gameplay when done testing

This will allow you to see the solution to the game as you test it.  Then reverse the changes again (to as shown above) to experience the game as intended.



## Project Requirements to be included

√  - create one class, instantiate an object of that class, and populate the object with data which is used OR displayed in the application.

	[ instantiates MemoryGameApp() into object named 'app',
	uses that object in Run() method inherited via CodeLouisvilleAppBase.cs.  
	Data from 'app' is displayed in the game.  ]

√  - create and call 3 functions or methods

	[ DisplayGameBoard()
	  WaitForAnyKeyPress()
	  CreateGameWords()  ]

√ - one of these must return a value that is used in the application


### Include three items from Feature List:

√  -  create master loop

	[ Main() loop and GamePlay() loop ]


√  - include a class that is inherited by another which uses one or more of the parent properties 
     
	[  CodeLouisvilleAppBase.cs is inherited by MemoryGameApp.cs   
		Its method Run() is used by Program.cs
		Its method TryPrompt4Integer is used by MemoryGameApp()
		Its method TryPrompt4MenuItem is used by MemoryGameApp() ]



√  - Create a list or dictionary, populate it with values, retrieve at least one value and use it. 

	[ several List collections created and used ]


√  - Use a LINQ query to retrieve info from a data structure such as a list or an array (or from a file).

	[ Words.cs uses LINQ methods  OrderBy(), Take(), and ToList() 
         in a query of word source to sort in random order to new list.  
         The results of the query are used to create a second list, 
         which is doubled and placed in random order using OrderBy() 
         and ToList() to serve as the words used in each game. ]
	
	
