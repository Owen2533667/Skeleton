using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        public string ItemDescription { get; set; }
        public DateTime OrderPlaced { get; set; }
        public string DeliveryAddress { get; set; }
        public int StaffId { get; set; }
        public int OrderNo { get; set; }
        public decimal ItemPrice { get; set; }
        public char ItemColour { get; set; }
        public bool ItemAvailability { get; set; }

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
    }
}
