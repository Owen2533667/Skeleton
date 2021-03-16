using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        private string mDescription = "Some description";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AOrder = new clsOrder();
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = mDescription;
            AOrder.Description = TestData;
            Assert.AreEqual(AOrder.Description, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TestData = mDescription;
            Error = AOrder.Valid(mDescription);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TestData = "";
            Error = AOrder.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = AOrder.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}
