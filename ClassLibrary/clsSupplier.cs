using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public static int Priceno { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string SupplierName { get; set; }

        public string Valid(string mDescription)
        {
            if (mDescription.Length < 1 )
            {
                return "Description Cannot be blank";
            }
            if (mDescription.Length > 50)
            {
                return "Description cannot be more than 50 characters ";
            }

            else
            {
            return "";
            }
            
        }
    }
}