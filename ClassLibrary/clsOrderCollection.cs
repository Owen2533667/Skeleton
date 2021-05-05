using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();


        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;

            }
        }

        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }





        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }



        }
        public void FilterByItemDescription(string ItemDescription)
        {
            //Filters the records based on a full or partial ItemDescription
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the OrderNo parameter to the database
            DB.AddParameter("@ItemDescription", ItemDescription);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByItemDescription");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AOrder = new clsOrder();
                AOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AOrder.ItemColour = Convert.ToString(DB.DataTable.Rows[Index]["ItemColour"]);
                AOrder.ItemPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPrice"]);
                AOrder.OrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderPlaced"]);
                AOrder.ItemAvailability = true;
                mOrderList.Add(AOrder);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", mThisOrder.ItemDescription);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@ItemColour", mThisOrder.ItemColour);
            DB.AddParameter("@ItemPrice", mThisOrder.ItemPrice);
            DB.AddParameter("@ItemAvailability", mThisOrder.ItemAvailability);
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            return DB.Execute("sproc_tblOrderProcessing_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@ItemDescription", mThisOrder.ItemDescription);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@ItemColour", mThisOrder.ItemColour);
            DB.AddParameter("@ItemPrice", mThisOrder.ItemPrice);
            DB.AddParameter("@ItemAvailability", mThisOrder.ItemAvailability);
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            DB.Execute("sproc_tblOrderProcessing_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }
    }

}
