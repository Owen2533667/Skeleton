using System;

namespace ClassLibrary
{
    public class clsGame
    {
        public string GameTitle { get; set; }
        public bool InStock { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string GameDescription { get; set; }

        public string valid(string gameTitle, string gameDescription, string price, string releaseDate, string stockQuantity)
        {
            //Create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            if (gameTitle.Length == 0)
            {
                Error = Error + "The Game Title may not be blank : ";
            }
            if (gameTitle.Length > 50)
            {
                Error = Error + "The Game title must be less than 50 characters : ";
            }
    

            //return any error message
            return Error;
        }
    }
}