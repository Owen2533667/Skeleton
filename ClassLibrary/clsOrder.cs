using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data for the OderNo
        private Int32 mOrderNo;
        private DateTime mOrderPlaced;
        private Int32 mStaffId;
        private String mItemDescription;
        private char mItemColour;
        private decimal mItemPrice;
        private Boolean mItemAvailability;
        private string mDeliveryAddress;


        public string ItemDescription
        {
            get
            {
                return mItemDescription;
            }
            set
            {
                mItemDescription = value;
            }
        }
        public DateTime OrderPlaced
        {
            get
            {
                return mOrderPlaced;
            }
            set
            {
                mOrderPlaced = value;

            }
        }
        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
                set
            {
                mDeliveryAddress = value;
            }
        }
        public int StaffId
        {
            get
            {
                return mStaffId;
            }  
            set
            {
                mStaffId = value;
            }
                
        }
        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;

            }
            set
            {
                mOrderNo = value;
            }
        }
        public decimal ItemPrice
        {
            get
            {
                return mItemPrice;
            }
            set
            {
                mItemPrice = value;
            }
        }
        public char ItemColour
        {
            get
            {
                return mItemColour;
            }
                set
            {
                mItemColour = value;
            }
        }
        public bool ItemAvailability
        {
            get
            {
                return mItemAvailability;
            }
                set
            {
                mItemAvailability = value;
            }
        }

        public string Valid(int OrderNo, string ItemDescription, int StaffId, string DeliveryAddress, char ItemColour, DateTime OrderPlaced, bool ItemAvailability, decimal ItemPrice)
        {
            if (OrderNo < 1)
            {
                return "OrderNo cannot be < than 1";
            }
            else if (OrderNo > 50)
            {
                return "OrderNo cannot be < than 1"; 
            }

            else if (ItemDescription.Length < 1)
            {
                return "ItemDescription length cannot be < 0";
            }
            else if (ItemDescription.Length > 50)
            {
                return "ItemDescription length cannot be >50 chars";
            }
            else if (StaffId < 1)
            {
                return "StaffId cannot be <1";
            }
            else if (StaffId > 500)
            {
                return "StaffId cannot be >500";
            }
            else if (DeliveryAddress.Length < 1)
            {
                return "DeliveryAddress cannot be blank";
            }
            else if (DeliveryAddress.Length > 50)
            {
                return "DeliveryAddress cannot be > 50 chars";
            }
            else if (ItemColour == ' ')
            {
                return "ItemColour cannot be empty";
            }
            else if (OrderPlaced <= DateTime.Now.AddYears(-1).AddDays(-1))
            {
                return "Orders which are older than 1 year are not processed";
            }
            else if (OrderPlaced > DateTime.Now)
            {
                return "OrderPlaced cannot be in the future";
            }
            else if (ItemPrice < 1)
            {
                return "ItemPrice can’t be < 1";
            }
            else if (ItemPrice > 10000)
            {
                return "ItemPrice cannot be >10000";
            }
            else
            {
                return "";
            }
        }

        public bool Find(int orderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemAvailability"]);
                mItemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                mItemColour = Convert.ToChar(DB.DataTable.Rows[0]["ItemColour"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderPlaced"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);

                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
