using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsGameCollection
    {
        //private data member for the list
        List<clsGame> mGameList = new List<clsGame>();
        //private data member thisGame
        clsGame mThisGame = new clsGame();

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
        //public property for ThisGame
        public clsGame ThisGame
        {
            get
            {
                //return the private data
                return mThisGame;
            }
            set
            {
                //set the private data
                mThisGame = value;
            }
        }

        //constructor for the class
        public clsGameCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblGames_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisGame
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@GameDescription", mThisGame.GameDescription);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@StockQuantity", mThisGame.StockQuantity);
            DB.AddParameter("@InStock", mThisGame.InStock);
            //execute the query returning the primary key value;
            return DB.Execute("sproc_tblGames_Insert");
        }

        public void Update()
        {
            //Update an existing record based on the value of thisGame
            //conenct to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@GameId", mThisGame.GameId);
            DB.AddParameter("@GameTitle", mThisGame.GameTitle);
            DB.AddParameter("@GameDescription", mThisGame.GameDescription);
            DB.AddParameter("@ReleaseDate", mThisGame.ReleaseDate);
            DB.AddParameter("@Price", mThisGame.Price);
            DB.AddParameter("@StockQuantity", mThisGame.StockQuantity);
            DB.AddParameter("@InStock", mThisGame.InStock);
            //Execute the stored procedure
            DB.Execute("sproc_tblGames_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisGame
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@GameId",mThisGame.GameId);
            //execute the stored procedure
            DB.Execute("sproc_tblGames_Delete");
        }

        public void ReportByGameTitle(string GameTitle)
        {
            //Filters the records based on a full or partial Game title
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the GameTitle parameter to the database
            DB.AddParameter("@GameTitle", GameTitle);
            //execute the stored procedure
            DB.Execute("sproc_tblGames_FilterByGameTitle");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mGameList = new List<clsGame>();
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
                //point at the next record
                Index++;
            }
        }
    }
}