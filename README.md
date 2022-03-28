## MemoryGame  - Code Louisville SQL class project


# Introduction
This repository is for my Code Louisville Winter 2022 C# course project. 

UNDER CONSTRUCTION

# Description

Classic memory testing game similar to Classic Concentration single player with the most basic of rules.  At this time object is to uncover all the matching words on the board   in as few turns as you can, relying on memory to help you make matches.


For the purposes of this project:
  ...

## Features

  ...


## Technical Instructions

  ...

## Project Requirements to be included

√  - create one class, instantiate an object of that class, and populate the object with data which is used OR displayed in the application.

	[ instantiates MemoryGameApp() into object named 'app',
	uses that object in Run() method inherited via CodeLouisvilleAppBase.cs.  
	Data from 'app' is displayed in the game.  ]

√  - create and call 3 functions or methods

	[ displayGameBoard()
	  WaitForAnyKeyPress()
	  ...   ]

	√ - one of these must return a value that is used in the application


### Include three items from Feature List:

√  -  create master loop

	[ gamePlay loop ]


√  - include a class that is inherited by another which uses one or more of the parent properties 
     
	[  CodeLouisvilleAppBase.cs is inherited by MemoryGameApp.cs   
		Its method Run() is used by Program.cs
		Its method TryPrompt4Integer is used by MemoryGameApp()
		Its method TryPrompt4MenuItem is used by MemoryGameApp() ]



√  - Create a list or dictionary, populate it with values, retrieve at least one value and use it. 

	[ several List collections created and used ]


   - Use a LINQ query to retrieve info from a data structure such as a list or an array (or from a file).

	  Select List of words retrieved in Random order, and  placed into display list for game play.
	
	[ CURRENTLY RECONFIGURING ]
