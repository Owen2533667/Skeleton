﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstGame
    {
        //Good test data
        // create some test data to pass to the method
        string GameId = "3";
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
        public void GameIdOK()
        {
            clsGame AGame = new clsGame();
            int TestData = 1;
            AGame.GameId = TestData;
            Assert.AreEqual(AGame.GameId, TestData);
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
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinLessOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "a";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "aa";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(49, '*');
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(50, '*');
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(51, '*');
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMid()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(25, '*');
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleExtremeMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameTitle = "";
            GameTitle = GameTitle.PadLeft(1000, '*');
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMinMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50).AddDays(-1);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50).AddDays(1);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(10);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String ReleaseDate = TestDate.ToString();
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String ReleaseDate = "this is not a date!";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMinMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            GameDescription = "a";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            GameDescription = "aa";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMaxMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            GameDescription = GameDescription.PadLeft(char.MaxValue - 1, 'a'); ;
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            GameDescription = GameDescription.PadLeft(char.MaxValue, 'a'); ;
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GameDescriptionMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            string GameDescription = "";
            GameDescription = GameDescription.PadLeft(char.MaxValue + 1, 'a'); ;
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String Price = "Owen";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String Price = "-10000000";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String Price = "-0.01";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String Price = "0.00";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String Price = "0.01";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityExtremeMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "-1000000";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMinMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "-1";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMin()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "0";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "1";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMaxMinusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "2147483646";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMax()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "2147483647";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "2147483648";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StockQuantityInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String StockQuantity = "Owen";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GameIdInvalidData()
        {
            clsGame AGame = new clsGame();
            string Error = "";
            String GameId = "Owen";
            Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Int32 GameId = 2;
            Found = AGame.Find(GameId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestGameIdFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.GameId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.ReleaseDate != Convert.ToDateTime("12/11/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameTitleFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.GameTitle != "MARVEL'S SPIDER-MAN: MILES MORALES")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameDescriptionFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.GameDescription != "Miles Morales discovers explosive powers that set him apart from his mentor, Peter Parker. Master his unique, bio-electric venom blast attacks and covert camouflage power alongside spectacular web-slinging acrobatics, gadgets and skills.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.StockQuantity != 1000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsGame AGame = new clsGame();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameId = 3;
            Found = AGame.Find(GameId);
            if (AGame.Price != Convert.ToDecimal(51.99))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
