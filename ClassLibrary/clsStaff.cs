using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private DateTime mEmploymentDate;
        private string mStaffAddress;
        private string mStaffName;
        private int mStaffNO;
        private Boolean mStaffGender;
        public string StaffName
        {
            get

            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public string staffAddress
        {
            get
            {
                return mStaffAddress;

            }
            set
            {
                mStaffAddress = value;
            }
        }
        public Int32 StaffNO
        {
            get
            {
                return mStaffNO;
            }
            set
            {
                mStaffNO = value;
            }
        }
        public DateTime EmploymentDate
        {
            get
            {
                return mEmploymentDate;
            }
            set
            {
                mEmploymentDate = value;
            }
            
        }

        public string Valid(string staffName, string staffAddress, string employmentDate, string staffNo)
        {
            string Error = "";
            DateTime DateTemp;
            int IntTemp;


            if (staffName.Length < 1)
            {
                Error = Error + "Staff Name cannot be left blank";
            }
            if (mStaffName.Length > 50)
            {
                Error = Error + " Name is greater than 50 characters";
            }
            if (staffAddress.Length < 1)
            {
                Error = Error + "invalid StaffAddress";
            }
            if (staffAddress.Length > 50)
            {
                Error = Error + "the The Staff Address can not be greater than 50 characters"
            }

            try
            {
                IntTemp = Convert.ToInt32(staffNo);
                if (IntTemp < 0)
                {
                    Error = Error + "Staff Nuumber can not ne lower than ZERO!";
                }
                if (IntTemp > Int32.MaxValue)
                {
                    Error = Error + "Max integer Value has been Exceeded";
                }
            }
            catch
            {
                Error = Error + "not a valid Staff Number";
            }
            try
            {
                DateTemp = Convert.ToDateTime(employmentDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-50))
                {
                    Error = Error + "no staff member was added 50 years ago ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + " Staff members cannot be addd in the future";
                }
            }
            catch
            {
                Error = Error + "invalid Date";
            }
            return Error;
        }
    }
}
       
    
