using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.ItemDescription = "multiplayer game";
            TestItem.StaffId = 24;
            TestItem.DeliveryAddress = "FK19 0JK";
            TestItem.ItemColour = "orange";
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemPrice = 50;
            TestItem.ItemAvailability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }



        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.ItemDescription = "multiplayer game";
            TestItem.StaffId = 24;
            TestItem.DeliveryAddress = "FK19 0JK";
            TestItem.ItemColour = "orange";
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemPrice = 50;
            TestItem.ItemAvailability = true;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 1;
            TestItem.ItemDescription = "multiplayer game";
            TestItem.StaffId = 24;
            TestItem.DeliveryAddress = "FK19 0JK";
            TestItem.ItemColour = "orange";
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemPrice = 50;
            TestItem.ItemAvailability = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.ItemDescription = "singleplayer game";
            TestItem.StaffId = 14;
            TestItem.DeliveryAddress = "AK20 0JK";
            TestItem.ItemColour = "blue";
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemPrice = 68;
            TestItem.ItemAvailability = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //test data to update
            TestItem.StaffId = 349;
            TestItem.DeliveryAddress = "SA70 8SQ";
            TestItem.ItemColour = "Green";
            TestItem.ItemPrice = 17;
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemDescription = "Single Player";
            TestItem.ItemAvailability = true;
            AllOrders.ThisOrder = TestItem;
            TestItem.OrderNo = PrimaryKey;
            //new test data
            TestItem.StaffId = 350;
            TestItem.DeliveryAddress = "SA71 8SQ";
            TestItem.ItemColour = "Purple";
            TestItem.ItemPrice = 20;
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemDescription = "Multi Player";
            TestItem.ItemAvailability = true;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //data to delete
            TestItem.StaffId = 349;
            TestItem.DeliveryAddress = "SA70 8SQ";
            TestItem.ItemColour = "Green";
            TestItem.ItemPrice = 17;
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.ItemDescription = "Single Player";
            TestItem.ItemAvailability = true;
            AllOrders.ThisOrder = TestItem;
            TestItem.OrderNo = PrimaryKey;

            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void FilterByItemDescriptionMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByItemDescription("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);

        }

        [TestMethod]
        public void FilterByItemDescriptionNoneFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.FilterByItemDescription("xxxxxxx");
            Assert.AreEqual(0, FilteredOrders.Count);

        }

        [TestMethod]
        public void FilterByItemDescriptionTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.FilterByItemDescription("Racing");
            if (FilteredOrders.Count == 1)
            {
                if (FilteredOrders.OrderList[0].OrderNo != 4)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
