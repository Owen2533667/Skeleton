using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        private string ItemDescription = "Valid description for product";
        private int OrderNo = 47;
        private int StaffId = 209;
        private DateTime OrderPlaced = DateTime.Now;
        private string ItemColour = "orange";
        private Boolean ItemAvailability = true;
        private string DeliveryAddress = "FK29 1LP 49 Street";
        private decimal ItemPrice = 3000;


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
            DateTime TestData = OrderPlaced;
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
            int TestData = StaffId;
            AOrder.StaffId = TestData;
            Assert.AreEqual(AOrder.StaffId, TestData);
        }

        [TestMethod]

        public void OrderNoOK()

        {
            clsOrder AOrder = new clsOrder();
            int TestData = OrderNo;
            AOrder.OrderNo = TestData;
            Assert.AreEqual(AOrder.OrderNo, TestData);
        }

        [TestMethod]

        public void ItemPriceOk()

        {
            clsOrder AOrder = new clsOrder();
            decimal TestData = ItemPrice;
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
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "b";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemDescriptionMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(25, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemDescriptionMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(50, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadLeft(51, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderNo = 0;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderNo = 1;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNoMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderNo = 25;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderNo = 50;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int OrderNo = 51;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int StaffId = 0;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int StaffId = 1;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIdMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int StaffId = 250;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StaffIdMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int StaffId = 500;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int StaffId = 501;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemColourBlank()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ItemColour = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMinMinusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderPlaced;
            OrderPlaced = DateTime.Now.Date;
            OrderPlaced = OrderPlaced.AddYears(-1).AddDays(-1);
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderPlaced;
            OrderPlaced = DateTime.Now.Date;
            OrderPlaced = OrderPlaced.AddYears(-1);
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderPlacedMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderPlaced;
            OrderPlaced = DateTime.Now.Date;
            OrderPlaced = OrderPlaced.AddMonths(-6);
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderPlaced;
            OrderPlaced = DateTime.Now.Date;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime OrderPlaced;
            OrderPlaced = DateTime.Now.Date;
            OrderPlaced = OrderPlaced.AddDays(+1);
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 0;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 1;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemPriceMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 5000;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemPriceMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            decimal ItemPrice = 10000;
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomeAddressMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "A";
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadLeft(25, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadLeft(50, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadLeft(51, '*');
            Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemAvailability, ItemPrice);
            Assert.AreNotEqual(Error, "");
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
    }
}
    

    


