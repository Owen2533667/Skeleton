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
        private String mItemColour;
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
        public string ItemColour
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


        public string Valid(string orderNo, string itemDescription, string staffId, string deliveryAddress, string itemColour, string orderPlaced, string itemPrice)

        {

            String Error = "";

            DateTime OrderPlacedTemp;

            Decimal ItemPriceTemp;

            int OrderNoTemp;

            int StaffIdTemp;



            if (deliveryAddress.Length < 1)

            {

                Error = Error + " DeliveryAddress cannot be < than 1: ";

            }

            if (deliveryAddress.Length > 50)

            {

                Error = Error + " DeliveryAddress cannot be > than 50: ";

            }

            if (itemDescription.Length < 1)

            {

                Error = Error + "ItemDescription cannot be blank: ";

            }

            if (itemDescription.Length > 50)

            {

                Error = Error + " ItemDescription cannot exceed 50 chars:";

            }

            if (itemColour.Length < 1)

            {

                Error = Error + "Item Colour cannot be less than 1";

            }

            if (itemColour.Length > 20)

            {

                Error = Error + "Item Colour cannot exceed 20 chars:";

            }

            try

            {

                OrderPlacedTemp = Convert.ToDateTime(orderPlaced);

                if (OrderPlacedTemp <= DateTime.Now.AddYears(-1).AddDays(-1))

                {

                    Error = Error + "OrderPlaced cannot be older than 1 year: ";

                }

                if (OrderPlacedTemp > DateTime.Now)

                {

                    Error = Error + "OrderPlaced cannot be after today: ";

                }

            }

            catch

            {

                Error = Error + "Invalid data for date: ";

            }

            try

            {

                ItemPriceTemp = Convert.ToDecimal(itemPrice);

                if (ItemPriceTemp < 1)

                {

                    Error = Error + "Item Price cannot be less than 1: ";

                }

                if (ItemPriceTemp > 10000)

                {

                    Error = Error + "Item Price cannot be >10000: ";

                }

            }

            catch

            {

                Error = Error + "Invalid data for Item Price: ";

            }



            try

            {

                OrderNoTemp = Convert.ToInt32(orderNo);

                if (OrderNoTemp < 1)

                {

                    Error = Error + "OrderNo cannot be less than 1: ";

                }

                if (OrderNoTemp > 50)

                {

                    Error = Error + "OrderNo cannot exceed number 50: ";

                }

            }

            catch

            {

                Error = Error + "Invalid data for OrdeNo:";

            }



            try

            {

                StaffIdTemp = Convert.ToInt32(staffId);

                if (StaffIdTemp < 1)

                {
                    Error = Error + "Staff ID cannot be less than 1: ";
                }
                if (StaffIdTemp > 500)
                {
                    Error = Error + "StaffId cannot exceed 500: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Staff Id:";
            }


            return Error;
        }


        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemAvailability"]);
                mItemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                mItemColour = Convert.ToString(DB.DataTable.Rows[0]["ItemColour"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderPlaced"]);


                return true;
            }
            else
            {
                return false;
            }

        }
    }
}