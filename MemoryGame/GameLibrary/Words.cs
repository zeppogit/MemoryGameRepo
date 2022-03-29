using System;
namespace GameLibrary
{
    public class Words
    {
        public static int numWords;


        public static List<string> wordSource = new List<string>() { "BIRD", "FISH", "LAMP", "FIRE", "SHOE", "OVEN", "BOOK", "TREE", "DOOR", "BOAT", "CARS", "ROAD", "HOME", "FOAM", "TRIP", "HARP", "MEAT", "FOOT", "FEET", "PALM", "OATS", "TEAM", "LOOP", "POOL", "HEAD", "JEEP", "COAT", "STOP", "PORT", "NICE", "COMB", "EASY", "GRID", "ICEY", "JOKE", "KNOT", "LICE", "MOAT", "NOTE", "OXEN", "QUAY", "RACE", "ROPE", "SAND", "VINE", "VOTE", "WHIP", "WEED", "EXIT", "YEAR", "DUNE", "YELP", "ZOOM" };

        public static List<string> shuffledStr = new List<string>();


        public Words()
        {
    
        }

        public static void CreateGameWords(int num)
        {
            int takeNum = num;
            Random r = new Random();

            // USE OF LINQ QUERY:
            shuffledStr = wordSource.OrderBy(w => r.Next()).Take(takeNum).ToList();

            for (int i = 0; i < takeNum; i++)
            {
                shuffledStr.Add(shuffledStr[i]);
            }
            shuffledStr = shuffledStr.OrderBy(w => r.Next()).ToList();  
        }
    }                  
}