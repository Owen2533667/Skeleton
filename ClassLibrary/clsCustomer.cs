using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Description { get; set; }

        // CustomerNumber private member variable
        private string mCustomerNumber;
        public string CustomerNumber
        {
            get
            {
                // sends data out
                return mCustomerNumber;
            }
            set
            {
                // lets data in
                mCustomerNumber = value;
            }
        }

        // CustomerName private member variable
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }

        // CustomerEmail private member variable
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        // CustomerDOB private member variable
        private DateTime mCustomerDOB;
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }

        // CustomerGender private member variable
        private string mCustomerGender;
        public string CustomerGender
        {
            get
            {
                return mCustomerGender;
            }
            set
            {
                mCustomerGender = value;
            }
        }

        // CustomerPostcode private member variable
        private string mCustomerPostcode;
        public string CustomerPostcode
        {
            get
            {
                return mCustomerPostcode;
            }
            set
            {
                mCustomerPostcode = value;
            }
        }

        public string Valid(string CustomerNumber, string CustomerName, string CustomerEmail, string CustomerDOB, string CustomerGender, string CustomerPostcode)
        {
            // variable created to store error
            string Error = "";
            // variable created to store temporary date
            DateTime DateTemporary;

            // checks if the length of customer number is 0
            if (CustomerNumber.Length == 0)
            {
                // if length is 0 this error message will be displayed
                Error = Error + "The Customer Number may not be blank : ";
            }

            // checks if the length of customer number is greater than 50
            if (CustomerNumber.Length > 50)
            {
                // if length is greater than 50 this error message will be displayed
                Error = Error + "The Customer Number is too long : ";
            }

            // checks if the length of customer name is 0
            if (CustomerName.Length == 0)
            {
                // if length is 0 this error message will be displayed
                Error = Error + "The Customer Name may not be blank : ";
            }

            // checks if the length of customer name is greater than 50
            if (CustomerName.Length > 50)
            {
                // if length is greater than 50 this error message will be displayed
                Error = Error + "The Customer Name is too long : ";
            }

            // checks if the length of customer email is 0
            if (CustomerEmail.Length == 0)
            {
                // if length is 0 this error message will be displayed
                Error = Error + "The Customer Email may not be blank : ";
            }

            // checks if the length of customer email is greater than 50
            if (CustomerEmail.Length > 50)
            {
                // if length is greater than 50 this error message will be displayed
                Error = Error + "The Customer Email is too long : ";
            }

            try
            {
                //CustomerDOB copied over to the new DateTemporary variable
                DateTemporary = Convert.ToDateTime(CustomerDOB);
                // checks if DateTemporary variable is over 100 years before now
                if (DateTemporary < DateTime.Now.Date.AddYears(-100))
                {
                    // if the statement is true this error message will be displayed
                    Error = Error + "We do not accept customers born over 100 years ago : ";
                }
                // checks if DateTemporary variable is less than 1 year before now
                if (DateTemporary > DateTime.Now.Date.AddYears(-1))
                {
                    // if the statement is true this error message will be displayed
                    Error = Error + "We do not accept customers born 1 year ago : ";
                }
            }

            catch
            {
                //assigns message to error variable
                Error = Error + "The date was not valid : ";
            }

            // checks if the length of customer gender is 0
            if (CustomerGender.Length == 0)
            {
                // if length is 0 this error message will be displayed
                Error = Error + "The Customer Gender may not be blank, if you would not like to disclose put 'NA' : ";
            }

            // checks if the length of customer gender is greater than 10
            if (CustomerGender.Length > 10)
            {
                // if length is greater than 10 this error message will be displayed
                Error = Error + "The Customer Gender is too long : ";
            }

            // checks if the length of customer postcode is 0
            if (CustomerPostcode.Length == 0)
            {
                // if length is 0 this error message will be displayed
                Error = Error + "The Customer Postcode may not be blank : ";
            }

            // checks if the length of customer postcode is greater than 10
            if (CustomerNumber.Length > 10)
            {
                // if length is greater than 10 this error message will be displayed
                Error = Error + "The Customer Postcode is too long : ";
            }

            return Error;
        }
    }
}