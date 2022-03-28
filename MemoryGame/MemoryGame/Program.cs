using System;
using System.Collections.Generic;
using System.Linq;
using CodeLouisvilleLibrary;




namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


        // PROJECT REQUIREMENT: Creates an object populated with data which is displayed in the game.  The object is of a class I created.

            var app = new MemoryGameApp();   
            app.Run();              // use Run() from base class


        }

    }
}


