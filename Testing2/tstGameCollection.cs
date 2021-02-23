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

    }

}
