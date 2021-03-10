using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public string Description { get; set; }

        public string Valid(string mDescription)
        {
            if (mDescription.Length < 1)
            {
                return "Description cannot be blank";
            }
            if (mDescription.Length > 50)
            {
                return "Description cannot be more than 50 characters";

            }
            else
            {
                return "";
            }
        
        }
    }
}