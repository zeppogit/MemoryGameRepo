namespace GameLibrary;
public class GameBoard
{

    /* ////////////////// BEGIN BLOCK COMMENT-OUT
     
  

    //POSSIBLY CREATE CreateGameBoard() method BUT will wait until I see how later possible use of JSON source factors in.

    /// THIS LING QUERY WILL GO INTO A DisplayGameBoard() method in GameBoard.cs class ////////////////////////
    /// 
    // The Three Parts of a LINQ Query:
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
    // PART 1. Data source.

    static List<string> words = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE" };

    //  DO I MAKE THE ABOvE PUBLIC OR private


    */  ///////////////////////  END BLOCK COMMMENT-OUT


    /*
    //IF I WERE TO USE WORDS.CS CLASS, a FUNCTION COULD RETURN A LIST OF TYPE WORDS FROM WORDS.CS

    public List<Words> GetWords()
    {
        return words;
    }

    */



    /*  //////////////////////////////// BEGIN BLOCK COMMENT OUT

    // The Three Parts of a LINQ Query:
    // PART 2. Query creation.
    Random r = new Random();   //System.Random()
    List<string> shuffledStr = words.OrderBy(w => r.Next()).Take(16).ToList();
    // Take(16) not necessary until list becomes larger than 16,
    // where the parameter now shown as 16 will become an option selected by player before game board appears


    List<string> numStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };




    List<string> displayStr = new List<string>() { " 01 ", " 02 ", " 03 ", " 04 ", " 05 ", " 06 ", " 07 ", " 08 ", " 09 ", " 10 ", " 11 ", " 12 ", " 13 ", " 14 ", " 15 ", " 16 " };


    //Console.WriteLine(string.Join(", ", shuffledStr.ToArray()));  //FOR TESTING
    //written to console for testing - in program, comment out previous line and uncomment the next line:
    //string.Join(", ", shuffledStr.ToArray());   //COMMENT THIS OUT WHEN TESTING AND UNCOMMENT PRIOR CONSOLE.WRITELINE






    // The Three Parts of a LINQ Query:
    // PART 3. Query execution.



    //CREATE DisplayGameBoard() method
    //
    //     public List<Words> DisplayGameBoard(_displayStr)
    //     {
    //         for (int i = 0; i< 13; i++, i++, i++, i++)
    //         {
    //             Console.WriteLine("    " + displayStr[i] + "    " + displayStr[i + 1] + "    " + displayStr[i + 2] + "    " + displayStr[i + 3]);
    //             Console.WriteLine();
    //         }
    //     }
    //

    */ ////////////////////////////END BLOCK COMMENT OUT

} 



