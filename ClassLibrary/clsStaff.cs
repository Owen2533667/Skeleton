using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Name property
        private string mName;
        public string Name  
            {
                get
                {
                    return mName;
                }
                set
                {
                    mName = value;
                }
      }
        private int mStaffNO;
        public int StaffNO
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
        private string mAddress;
          public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        private DateTime mEmploymentDate;
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
        private decimal mSalary;
        public decimal Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        private DateTime mDOB;
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        private Boolean mGender;
        public Boolean Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }

        public bool Find(string Name)
        {
            //set the private data members to the test data value
            mName = "Michael";
            mEmploymentDate = Convert.ToDateTime("21/03/2020");
            mDOB = Convert.ToDateTime("30/03/1999");
            mAddress = "Test Address";
            mStaffNO = 3456;
            mSalary = 5000000;
            mGender = true;
            //always true
            return true;
        }
    }
}
    

       
    
