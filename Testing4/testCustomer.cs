using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class testCustomer
    {

        //good test data
        private string CustomerNumber = "123";
        private string CustomerName = "James Smith";
        private string CustomerEmail = "jamesmith@yahoo.co.uk";
        private string CustomerDOB = DateTime.Now.Date.ToString();
        private string CustomerGender = "M";
        private string CustomerPostcode = "LE29DW";

        [TestMethod]
        public void InstanceOK()
        {
             clsCustomer ACustomer = new clsCustomer();
             Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerNumberOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            var TestData = "123";
            ACustomer.CustomerNumber = TestData;
            Assert.AreEqual(ACustomer.CustomerNumber, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            var TestData = "James Smith";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            var TestData = "jamessmith@gmail.com";
            ACustomer.Description = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustomerDOB = TestData;
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerGenderOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            var TestData = "M";
            ACustomer.CustomerGender = TestData;
            Assert.AreEqual(ACustomer.CustomerGender, TestData);
        }

        [TestMethod]
        public void CustomerPostcodeOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            var TestData = "LE27FP";
            ACustomer.Description = TestData;
            Assert.AreEqual(ACustomer.CustomerPostcode, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Some Description";
            ACustomer.Description = TestData;
            Assert.AreEqual(ACustomer.Description, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreEqual(Error,"");
        }

        //CUSTOMER NUMBER

        [TestMethod]
        public void CustomerNumberMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "1";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "11";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadLeft(49, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadLeft(50, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadLeft(51, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadLeft(25, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNumberExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerNumber = CustomerNumber.PadLeft(1500, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        //END OF CUSTOMER NUMBER

        //CUSTOMER Name

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "J";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "Jo";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(49, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(50, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerNumber = "";
            CustomerName = CustomerName.PadLeft(51, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(25, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(1500, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        //END OF CUSTOMER NAME

        //CUSTOMER EMAIL

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "t";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "t@";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(49, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(50, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(51, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(25, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadLeft(1500, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        //END OF CUSTOMER EMAIL

        //CUSTOMER DOB

        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-150);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100).AddDays(1);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String CustomerDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            String CustomerDOB = "this is not a date!";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        // END OF CUSTOMER DOB

        // CUSTOMER GENDER

        [TestMethod]
        public void CustomerGenderMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "M";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "NB";
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(9, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(10, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(11, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(5, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerGenderExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(100, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        // END OF CUSTOMER GENDER

        // CUSTOMER POSTCODE

        [TestMethod]
        public void CustomerPostcodeMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(5, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(6, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(7, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(9, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerGender = "";
            CustomerGender = CustomerGender.PadLeft(10, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(11, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(5, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostcodeExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerPostcode = "";
            CustomerPostcode = CustomerPostcode.PadLeft(100, '*');
            Error = ACustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
            Assert.AreNotEqual(Error, "");
        }

        // END OF CUSTOMER POSTCODE
    }
}
