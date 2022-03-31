using System;
namespace GameLibrary
{
    public class Words
    {

        // The Three Parts of a LINQ Query:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
        //Create the data source

        public static List<string> wordSource = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "DOOR", "BOAT", "CARS", "ROAD", "HOME", "FOAM", "TRIP", "HARP", "MEAT", "FOOT", "FEET", "PALM", "OATS", "TEAM", "LOOP", "POOL", "HEAD", "JEEP", "COAT", "STOP", "PORT", "NICE", "COMB", "EASY", "GRID", "ICEY", "JOKE", "KNOT", "LICE", "MOAT", "NOTE", "OXEN", "QUAY", "RACE", "ROPE", "SAND", "VINE", "VOTE", "WHIP", "WEED", "EXIT", "YEAR", "DUNE", "YELP", "ZOOM" };

        public static List<string> shuffledStr = new List<string>();

        public static List<string> solutionStr = new List<string>();  
        
        public Words()
        {
    
        }

        public static void CreateGameWords(int num)
        {
            int takeNum = num;

            // The Three Parts of a LINQ Query:
            // PART 2. Query creation:

            Random r = new Random();
            shuffledStr = wordSource.OrderBy(w => r.Next()).Take(takeNum).ToList();

            for (int i = 0; i < takeNum; i++)
            {
                shuffledStr.Add(shuffledStr[i]);
            }
            shuffledStr = shuffledStr.OrderBy(w => r.Next()).ToList();

            // The Three Parts of a LINQ Query:
            // PART 3. Query execution :  DisplayGameBoard() makes displays shuffleStr in app

            solutionStr = shuffledStr.ToList();


        }
    }                  
}