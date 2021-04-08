using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TstGameSupplier
    {
        private string mDescription = "Description";
        private string mSupplier;

        [TestMethod]
        public void InstanceOk()
        {
            clsSupplier Agame = new clsSupplier();
            Assert.IsNotNull(Agame);
        }

        [TestMethod]
        public void Description()
        {
            clsSupplier Agame = new clsSupplier();
            string TestData = mDescription;
            Agame.Description = TestData;
            Assert.AreEqual(Agame.Description, TestData);
        }

        public void SupplierName()
        {
            //create an instance of the class we want to create
            clsSupplier Agame = new clsSupplier();
            //create some test data to assign to the property
            string TestData = mSupplier;
            //assign the data to the property
            Agame.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Agame.SupplierName, TestData);
        }

        [TestMethod]
        public void Price()
        {
            //create an instance of the class we want to create
            clsSupplier Agame = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            clsSupplier.Priceno = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(clsSupplier.Priceno, TestData);
        }

               
        [TestMethod]
        public void ReleaseDate()
        {
            //create an instance of the class we want to create
            clsSupplier Agame = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Agame.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Agame.DateAdded, TestData);
        }



    }

    [TestMethod]
        public void Valid()
        {
            clsSupplier Agame = new clsSupplier();
            string Error = "";
            string TestData = mDescription;
            Error = Agame.Valid(mDescription);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MinLessOne()
        {
            clsSupplier Agame = new clsSupplier();
            string Error = "";
            string TestData = "";
            Error = Agame.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsSupplier Agame = new clsSupplier();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = Agame.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}
