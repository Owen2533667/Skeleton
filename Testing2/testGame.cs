using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class testGame
    {
        //Good test data
        // create some test data to pass to the method
        string GameTitle = "A Game Title";
        string GameDescription = "A Game Description";
        string Price = "60";
        string ReleaseDate = DateTime.Now.Date.ToString();
        string StockQuantity = "1000";

        [TestMethod]
        public void InstanceOK()
        {
            clsGame AGame = new clsGame();
            Assert.IsNotNull(AGame);
        }

        [TestMethod]
        public void GameTitleOK()
        {
            clsGame AGame = new clsGame();
            string TestData = "A Game Title";
            AGame.GameTitle = TestData;
            Assert.AreEqual(AGame.GameTitle, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            clsGame AGame = new clsGame();
            Boolean TestData = true;
            AGame.InStock = TestData;
            Assert.AreEqual(AGame.InStock, TestData);
        }

        [TestMethod]
        public void ReleaseDateOK()
        {
            clsGame AGame = new clsGame();
            DateTime TestData = DateTime.Now.Date;
            AGame.ReleaseDate = TestData;
            Assert.AreEqual(AGame.ReleaseDate, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsGame AGame = new clsGame();
            decimal TestData = 60;
            AGame.Price = TestData;
            Assert.AreEqual(AGame.Price, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            clsGame AGame = new clsGame();
            Int32 TestData = 1000;
            AGame.StockQuantity = TestData;
            Assert.AreEqual(AGame.StockQuantity, TestData);
        }

        [TestMethod]
        public void GameDescriptionOK()
        {
            clsGame AGame = new clsGame();
            string TestData = "A description of the game is that it is a game";
            AGame.GameDescription = TestData;
            Assert.AreEqual(AGame.GameDescription, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinLessOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "a";
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "aa";
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(49, '*');
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(50, '*');
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(51, '*');
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMid()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(25, '*');
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleExtremeMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(1000, '*');
            Error = AGame.valid(GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }
    }
}
