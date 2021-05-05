using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNumber = Convert.ToInt32(Session["CustomerNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerNumber);

        Response.Redirect("CustomerList.aspx");
    }
}