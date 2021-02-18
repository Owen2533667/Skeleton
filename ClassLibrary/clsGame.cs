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

        public string Valid(string gameTitle, string gameDescription, string price, string releaseDate, string stockQuantity)
        {
            //Create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create a temporary variable to store decimal values
            decimal DecimalTemp;
            //create a temporary variable to store int values
            int IntTemp;

            //if statemen for checking if gameTitle is equal to 0
            if (gameTitle.Length == 0)
            {
                //Assigns message to Error variable
                Error = Error + "The Game Title may not be blank : ";
            }
            //if statemen for checking if gameTitle is above 50
            if (gameTitle.Length > 50)
            {
                //Assigns message to Error variable
                Error = Error + "The Game title must be less than 50 characters : ";
            }
            //if statemen for checking if gameDescription is equal to 0
            if (gameDescription.Length == 0)
            {
                //Assigns message to Error variable
                Error = Error + "The Game description may not be blank : ";
            }
            //if statemen for checking if gameDescription lengh is aboce char max value
            if (gameDescription.Length > char.MaxValue)
            {
                //Assigns message to Error variable
                Error = Error + "The Game description may not be over 100000 characters : ";
            }
            try
            {
                //copy the releaseDate value to the dateTemp variable
                DateTemp = Convert.ToDateTime(releaseDate);
                //if statemen for checking if DateTemp is below current date - 50 years
                if (DateTemp < DateTime.Now.Date.AddYears(-50))
                {
                    //Assigns message to Error variable
                    Error = Error + "We do not sell games released 50 years ago : ";
                }
                //if statemen for checking if Date is above current date plus 10 years
                if (DateTemp > DateTime.Now.Date.AddYears(10))
                {
                    //Assigns message to Error variable
                    Error = Error + "We do not sell games that have a relase date over 10 years from current date : ";
                }
            }
            catch
            {
                //Assigns message to Error variable
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                //copy the price value to the DecimalTemp variable
                DecimalTemp = Convert.ToDecimal(price);
                //if statemen for checking if DecimalTemp is below zero
                if (DecimalTemp < 0)
                {
                    //Assigns message to Error variable
                    Error = Error + "The price cannot be lower than zero : ";
                }
                //if statemen for checking if DecimalTemp is above Decimal max value
                if (DecimalTemp > decimal.MaxValue)
                {
                    //Assigns message to Error variable
                    Error = Error + "The price cannot be higher than the decimal max value  : ";
                }
            }
            catch
            {
                //Assigns message to Error variable
                Error = Error + "The price entered was not a valid price : ";
            }

            try
            {
                //copy the StockQuantity value to the IntTemp variable
                IntTemp = Convert.ToInt32(stockQuantity);
                //if statemen for checking if IntTemp is below zero
                if (IntTemp < 0)
                {
                    //Assigns message to Error variable
                    Error = Error + "The Stock quantity cannot be lower than zero : ";
                }
                //if statemen for checking if IntTemp is above int max value
                if (IntTemp > Int32.MaxValue)
                {
                    //Assigns message to Error variable
                    Error = Error + "The Stock quantity cannot be higher than the Int max value  : ";
                }
            }
            catch
            {
                //Assigns message to Error variable
                Error = Error + "The Stock quantity entered was not a valid Stock quantity : ";
            }

            return Error;
        }   
    }
}