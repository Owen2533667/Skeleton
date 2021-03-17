using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        //good method
        private string StaffName = "Staff Name";
        private string StaffAddress = "Staff Address";
        private string EmploymentDate = DateTime.Now.Date.ToString();
        private string StaffNO = "3";

        [TestMethod]
        public void InstanceOk()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        [TestMethod]
        public void StaffNameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "a staff member name";
            aStaff.StaffName = TestData;
            Assert.AreEqual(aStaff.StaffName, TestData);
        }

      
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            StaffName = StaffName.PadLeft(51, '*');
            Error = aStaff.Valid(StaffName ,StaffAddress, EmploymentDate,StaffNO;
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxMinOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            StaffName = StaffName.PadLeft(49, '*');
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate,StaffNO);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinMinOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = StaffAddress;
            aStaff.staffAddress = TestData;
            Assert.AreEqual(aStaff.staffAddress, TestData, EmploymentDate);
        }

        [TestMethod]
        public void StaffAddressMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "";
            Error = aStaff.Valid(StaffName, StaffAddress,EmploymentDate, StaffNO);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadLeft(51, '*');
            Error = aStaff.Valid(StaffName, StaffAddress,EmploymentDate,StaffNO);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "a";
            Error = aStaff.Valid(StaffName, StaffAddress,EmploymentDate, StaffNO);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadLeft(50, '*');
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreEqual(Error, "");
        }
        public void StaffAddressMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffName = "aa";
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO );
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNoOK()
        {
            clsStaff aStaff = new clsStaff();
            int TestData = 3;
            aStaff.StaffNO = TestData;
            Assert.AreEqual(aStaff.StaffNO, TestData);
        }

        [TestMethod]
        public void EmploymentDateMinMinusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50).AddDays(-1);
            string EmploymentDate = TestDate.ToString();
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmploymentDateMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50).AddDays(1);
            String EmploymentDate = TestDate.ToString();
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmploymentDateMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(10);
            String Employment = TestDate.ToString();
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate,StaffNO);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmploymentDateExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(150);
            String Employment = TestDate.ToString();
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate, StaffNO);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmploymentDateInvalidDate()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            String EmploymentDate = "This Date is Invalid!";
            Error = aStaff.Valid(StaffName, StaffAddress, EmploymentDate,StaffNO);
            Assert.AreEqual(Error, "");
        }
       
    }
}
    

