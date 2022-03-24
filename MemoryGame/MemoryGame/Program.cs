using System;
using System.Collections.Generic;
using System.Linq;
using CodeLouisvilleLibrary;




namespace MemoryGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //THIS WILL CONTAIN THE RUN() INSTRUCTIONS FOR THE PROGRAM, NOT THE USER INTERFACE


        static void Main(string[] args)
        {
            // If I were to switch to larger json file of words to select 16 from, then use next two lines
            //string saveFilePath = @":\Users\jsweeney\Projects\MemoryGameRepo\MemoryGame\words.json"; // not sure of filepath
            // var app = new MemoryGameApp(saveFilePath);

            var app = new MemoryGameApp();
            app.Run();              // use Run() from base class


        }

    }
}


