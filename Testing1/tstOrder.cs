using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string ItemDescription = "Valid description for product";
        string OrderNo = "42";
        string StaffId = "209";
        string OrderPlaced = DateTime.Now.Date.ToString();
        string ItemColour = "orange";
        Boolean ItemAvailability = true;
        string DeliveryAddress = "FK29 1LP 49 Street";
        string ItemPrice = "3000";


        [TestMethod]
        public void ItemDescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = ItemDescription;
            AOrder.ItemDescription = TestData;
            Assert.AreEqual(AOrder.ItemDescription, TestData);
        }

        [TestMethod]

        public void ItemAvailabilityOK()

        {
            clsOrder AOrder = new clsOrder();
            Boolean TestData = ItemAvailability;
            AOrder.ItemAvailability = TestData;
            Assert.AreEqual(AOrder.ItemAvailability, TestData);
        }

        [TestMethod]

        public void OrderPlacedOK()

        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderPlaced = TestData;
            Assert.AreEqual(AOrder.OrderPlaced, TestData);
        }

        [TestMethod]

        public void DeliveryAddressOK()

        {
            clsOrder AOrder = new clsOrder();
            String TestData = DeliveryAddress;
            AOrder.DeliveryAddress = TestData;
            Assert.AreEqual(AOrder.DeliveryAddress, TestData);
        }

        [TestMethod]

        public void StaffIdOK()

        {
            clsOrder AOrder = new clsOrder();
            int TestData = 46;
            AOrder.StaffId = TestData;
            Assert.AreEqual(AOrder.StaffId, TestData);
        }

        [TestMethod]

        public void OrderNoOK()

        {
            clsOrder AOrder = new clsOrder();
            int TestData = 4;
            AOrder.OrderNo = TestData;
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }

        [TestMethod]

        public void ItemPriceOk()

        {
            clsOrder AOrder = new clsOrder();
            decimal TestData = 1000;
            AOrder.ItemPrice = TestData;
            Assert.AreEqual(AOrder.ItemPrice, TestData);
        }

        [TestMethod]
        public void ItemColourOk()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = ItemColour;
            AOrder.ItemColour = TestData;
            Assert.AreEqual(AOrder.ItemColour, TestData);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void OrderNoFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.OrderNo != 5)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPlacedFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.OrderPlaced != Convert.ToDateTime("18/04/2021"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffIdFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.StaffId != 125)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ItemDescriptionFind()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.ItemDescription != "Multiplayer minigames max 10 people ")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ItemColourFind()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.ItemColour != "Orange")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ItemPriceFind()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.ItemPrice != 12)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ItemAvailabilityFind()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.ItemAvailability != true)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DeliveryAddressFind()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 5;
            Found = AOrder.Find(OrderNo);
            if (AOrder.DeliveryAddress != "FK17 8AJ")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderNoExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int TestData;
            TestData = -100;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderNoMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderNoMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 25;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderNoMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 50;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 51;
            string OrderNo = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void OrderNoInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string OrderNo = "invalid";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int TestData;
            TestData = -10000;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 250;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 500;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 501;
            string StaffId = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void StaffIdInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string StaffId = "invalid";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderPlacedExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderPlacedMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1).AddDays(-1);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);

            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1000);
            string OrderPlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderPlacedInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string OrderPlaced = "Not valid date";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ItemPriceExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = -1000;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 0;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 1;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 5000;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 10000;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemPriceMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 10001;
            string ItemPrice = TestData.ToString();
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ItemPriceInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemPrice = "aaa";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ItemDescriptionMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemDescriptionMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "a";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemDescriptionMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(25, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemDescriptionMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(50, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemDescriptionMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(51, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ItemDescriptionExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(201, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "a";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(25, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(50, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(51, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(1001, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ItemColourMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "a";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(10, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice); Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(20, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemColourMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(21, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ItemColourExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            ItemColour = ItemColour.PadRight(10001, 'a');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);
            Assert.AreNotEqual(Error, "");

        }



    }
}
