using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //instance of clsStaff
        clsStaff aStaff = new clsStaff();
        // capture staff Number
        aStaff.Name = txtBoxName.Text;
        aStaff.StaffNO = txtBoxStaffNumber.Text;
        aStaff.Salary = txtBoxSalary;
        aStaff.DOB = txtBoxDOB.Date.Time;
        // store the staff in the session object
        Session["aStaff"] = aStaff;
        //Navigates to viewer page
        Response.Redirect("StaffViewer.aspx");


    }
}