using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsGameCollection
    {
        //private data member for the list
        List<clsGame> mGameList = new List<clsGame>();

        //Public property for the game list
        public List<clsGame> GameList
        {
            get
            {
                //return the private data
                return mGameList;
            }
            set
            {
                //set the private data
                mGameList = value;
            }
        }
        //Public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mGameList.Count;
            }
            set
            {

            }
        }
        public clsGame ThisGame { get; set; }

        //constructor for the class
        public clsGameCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblGames_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank game
                clsGame AGame = new clsGame();
                //read in the fields from the current record
                AGame.GameId = Convert.ToInt32(DB.DataTable.Rows[Index]["GameId"]);
                AGame.GameTitle = Convert.ToString(DB.DataTable.Rows[Index]["GameTitle"]);
                AGame.GameDescription = Convert.ToString(DB.DataTable.Rows[Index]["GameDescription"]);
                AGame.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AGame.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AGame.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AGame.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the record to the private data member
                mGameList.Add(AGame);
                //pont at the next record
                Index++;
            }
        }
    }
}