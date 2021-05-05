using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        public clsCustomer TestCustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerNumber = 1;
            TestItem.CustomerName = "Michael Smith";
            TestItem.CustomerEmail = "Msmith@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "M";
            TestItem.CustomerPostcode = "LE1 1AB";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerNumber = 1;
            TestCustomer.CustomerName = "Michael Smith";
            TestCustomer.CustomerEmail = "Msmith@gmail.com";
            TestCustomer.CustomerDOB = DateTime.Now.Date;
            TestCustomer.CustomerGender = "M";
            TestCustomer.CustomerPostcode = "LE1 1AB";
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerNumber = 1;
            TestItem.CustomerName = "Michael Smith";
            TestItem.CustomerEmail = "Msmith@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "M";
            TestItem.CustomerPostcode = "LE1 1AB";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.AreEqual(AllCustomers.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerNumber = 1;
            TestItem.CustomerName = "Michael Smith";
            TestItem.CustomerEmail = "Msmith@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "M";
            TestItem.CustomerPostcode = "LE1 1AB";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNumber = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerNumber = 1;
            TestItem.CustomerName = "Michael Smith";
            TestItem.CustomerEmail = "Msmith@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "M";
            TestItem.CustomerPostcode = "LE1 1AB";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNumber = PrimaryKey;
            TestItem.CustomerNumber = 3;
            TestItem.CustomerName = "Jane Paul";
            TestItem.CustomerEmail = "jp@msn.co.uk";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "F";
            TestItem.CustomerPostcode = "B42 2QJ";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerNumber = 1;
            TestItem.CustomerName = "Michael Smith";
            TestItem.CustomerEmail = "Msmith@gmail.com";
            TestItem.CustomerDOB = DateTime.Now.Date;
            TestItem.CustomerGender = "M";
            TestItem.CustomerPostcode = "LE1 1AB";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNumber = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        public void ReportByCustomerNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerName("xxxxx xxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        public void ReportByCustomerNameTestDataFound(string v)
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByCustomerName("xxxx xxxxx");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerNumber != 7)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerNumber != 8)
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

