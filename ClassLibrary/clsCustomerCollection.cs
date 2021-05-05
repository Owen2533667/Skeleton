using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.CustomerNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNumber"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AnCustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.CustomerGender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnCustomer.CustomerPostcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);

                mCustomerList.Add(AnCustomer);

                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@email", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@Gender", mThisCustomer.CustomerGender);
            DB.AddParameter("@Postcode", mThisCustomer.CustomerPostcode);

            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@email", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@Gender", mThisCustomer.CustomerGender);
            DB.AddParameter("@Postcode", mThisCustomer.CustomerPostcode);

            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNumber", mThisCustomer.CustomerNumber);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            PopulateArray(DB);
        }
    }

}