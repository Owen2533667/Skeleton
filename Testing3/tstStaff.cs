using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {


        [TestMethod]
        public void InstanceOk()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void StaffNameOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            string TestData = "Michael";
            //assign data to property
            aStaff.Name = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.Name, TestData);
        }
        [TestMethod]
        public void StaffNoOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            Int32 TestData = 4;
            //assign data to property
            aStaff.StaffNO = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.StaffNO, TestData);
        }
        [TestMethod]
        public void StaffAddressOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            string TestData = "23 claire Street";
            //assign data to property
            aStaff.Address = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.Address, TestData);
        }
        [TestMethod]
        public void EmploymentDateOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            aStaff.EmploymentDate = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.EmploymentDate, TestData);
        }
        [TestMethod]
        public void StaffSalaryOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            decimal TestData = 000;
            //assign data to property
            aStaff.Salary = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.Salary, TestData);
        }
        [TestMethod]
        public void StaffDOB()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            aStaff.DOB = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.DOB, TestData);
        }
        [TestMethod]
        public void StaffGenderOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            //test data
            Boolean TestData = true;
            //assign data to property
            aStaff.Gender = TestData;
            //test to see if two values are the same
            Assert.AreEqual(aStaff.Gender, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the validation
            Boolean Found = false;
            //create test data
            string Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffNamefound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            string Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.Name != "Michael")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressfound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            string Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.Address != "Test Address")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffDOBfound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            String Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.DOB != Convert.ToDateTime("30/03/1999"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEmploymentDatefound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            String Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.EmploymentDate != Convert.ToDateTime("21/03/2020"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffNOfound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            String Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.StaffNO != 3456)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            String Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.Salary != 5000000)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffGenderFound()
        {
            //instance of class created
            clsStaff aStaff = new clsStaff();
            // Bollean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create test data
            String Name = "Michael";
            // invoke find method
            Found = aStaff.Find(Name);
            if (aStaff.Gender != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }

}


