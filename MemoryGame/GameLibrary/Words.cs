using System;
namespace GameLibrary
{
    public class Words
    {
       /*
        * public List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };
        //  DO I MAKE THE ABOvE PUBLIC OR private

        public Words()
        {
            // CREATE LIST HERE AND MAKE ABOVE DATA SOURCE A STRING ?  STRING COULD COME FROM JSON OR HARDCODED AS ABOVE  ??
        }
       */
    }
}

//SKETCHING OUT A QUERY METHOD BELOW
// MAY ADD AN EXTENSION METHOD


// PART 1. Data source:
// **CHANGE DATA SOURCE TO IEnumerable<string> OR IEnumerable<int><List> OR IEnumerable<T> ?


/*
 * 
 * 
private static List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

// The Three Parts of a LINQ Query:
// PART 2. Query creation:

private static Random r = new Random();   //System.Random()
private static List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();

private static List<string> words = wordSource.OrderBy(w => r.Next()).Take(8).ToList();
//// Execute the query.

foreach (word i in words)
{
    words.Add(word);
}

private static List<string> gameWords = words.OrderBy(w => r.Next()).Take(16).ToList();





/*

//NOTING CURRENT working STATE OF memorygameapp.cs() before Main():


namespace MemoryGame
{
    public class MemoryGameApp : CodeLouisvilleAppBase
    {

        private static List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };

        private static List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };


        /// THIS LING QUERY WILL GO INTO A DisplayGameBoard() method in GameBoard.cs class ////////////////////////
        /// 
        // The Three Parts of a LINQ Query:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
        // PART 1. Data source:

        private static List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

        // The Three Parts of a LINQ Query:
        // PART 2. Query creation:

        private static Random r = new Random();   //System.Random()

        private static List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();
        // Take(16) not necessary until list becomes larger than 16,
        // where the parameter now shown as 16 will become an option selected by player before game board appears


        public MemoryGameApp() : base("Memory Game")  // name in quotes provided to be implemented in Welcome()

        // may take parameter variable storing json filepath defined in Program.cs
        {
            // may take block of code instantiating object that property of a  list of possible words (taken from json)
            // creation of object would run deserializer


            //public MemoryGameApp(string saveFilePath) : base("Memory Game")
        }



        /*