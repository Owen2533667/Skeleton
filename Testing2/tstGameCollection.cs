using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstGameCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            Assert.IsNotNull(AllGames);
        }

        [TestMethod]
        public void GameListOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            List<clsGame> TestList = new List<clsGame>();
            clsGame TestItem = new clsGame();

            TestItem.GameId = 1;
            TestItem.GameTitle = "A Game Name";
            TestItem.GameDescription = "A Game Description";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.StockQuantity = 200;
            TestItem.InStock = true;

            TestList.Add(TestItem);
            AllGames.GameList = TestList;

            Assert.AreEqual(AllGames.GameList, TestList);

        }

        [TestMethod]
        public void ThisGamePropertyOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            clsGame TestGame = new clsGame();

            TestGame.GameId = 1;
            TestGame.GameTitle = "A Game Name";
            TestGame.GameDescription = "A Game Description";
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.Price = 20;
            TestGame.StockQuantity = 200;
            TestGame.InStock = true;

            AllGames.ThisGame = TestGame;

            Assert.AreEqual(AllGames.ThisGame, TestGame);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsGameCollection AllGames = new clsGameCollection();
            List<clsGame> TestList = new List<clsGame>();

            clsGame TestGame = new clsGame();
            TestGame.GameId = 1;
            TestGame.GameTitle = "A Game Name";
            TestGame.GameDescription = "A Game Description";
            TestGame.ReleaseDate = DateTime.Now.Date;
            TestGame.Price = 20;
            TestGame.StockQuantity = 200;
            TestGame.InStock = true;

            TestList.Add(TestGame);
            AllGames.GameList = TestList;

            Assert.AreEqual(AllGames.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance if the class we want to create
            clsGameCollection AllGames = new clsGameCollection();
            //Create the item of test data
            clsGame TestItem = new clsGame();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.GameId = 1;
            TestItem.GameTitle = "A Game Name";
            TestItem.GameDescription = "A Game Description";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.StockQuantity = 200;
            TestItem.InStock = true;
            //set ThisGame to the test data
            AllGames.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGames.Add();
            //set the primary key of the test data
            TestItem.GameId = PrimaryKey;
            //find the record
            AllGames.ThisGame.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllGames.ThisGame, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance if the class we want to create
            clsGameCollection AllGames = new clsGameCollection();
            //Create the item of test data
            clsGame TestItem = new clsGame();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.GameTitle = "A Game Name";
            TestItem.GameDescription = "A Game Description";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.StockQuantity = 200;
            TestItem.InStock = true;
            //set ThisGame to the test data
            AllGames.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGames.Add();
            //set the primary key of the test data
            TestItem.GameId = PrimaryKey;
            //modify the test data
            TestItem.GameTitle = "A Game new cool Name";
            TestItem.GameDescription = "Description of a game new cool name";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = 60;
            TestItem.StockQuantity = 2000;
            TestItem.InStock = true;
            //set the reord based on the new test data
            AllGames.ThisGame = TestItem;
            //update the record
            AllGames.Update();
            //find the record
            AllGames.ThisGame.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllGames.ThisGame, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance if the class we want to create
            clsGameCollection AllGames = new clsGameCollection();
            //Create the item of test data
            clsGame TestItem = new clsGame();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.GameTitle = "A Game Name";
            TestItem.GameDescription = "A Game Description";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.Price = 20;
            TestItem.StockQuantity = 200;
            TestItem.InStock = true;
            //set ThisGame to the test data
            AllGames.ThisGame = TestItem;
            //add the record
            PrimaryKey = AllGames.Add();
            //set the primary key of the test data
            TestItem.GameId = PrimaryKey;
            //find the record
            AllGames.ThisGame.Find(PrimaryKey);
            //delete the record
            AllGames.Delete();
            //now find the record
            Boolean Found = AllGames.ThisGame.find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
    }
}
