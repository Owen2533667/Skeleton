using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TstGameSupplier
    {
        private string mDescription = "Description";
        [TestMethod]
        public void InstanceOk()
        {
            ClsGame Agame = new ClsGame();
            Assert.IsNotNull(Agame);
        }

        [TestMethod]
        public void DescriptionOk()
        {
            ClsGame Agame = new ClsGame();
            string TestData = mDescription;
            Agame.Description = TestData;
            Assert.AreEqual(Agame.Description, TestData);
        }

        [TestMethod]
        public void ValidOk()
        {
            ClsGame Agame = new ClsGame();
            string Error = "";
            string TestData = mDescription;
            Error = Agame.Valid(mDescription);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MinLessOne()
        {
            ClsGame Agame = new ClsGame();
            string Error = "";
            string TestData = "";
            Error = Agame.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            ClsGame Agame = new ClsGame();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = Agame.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}
