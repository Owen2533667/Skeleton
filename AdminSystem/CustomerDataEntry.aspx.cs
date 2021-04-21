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
        clsCustomer AnCustomer = new clsCustomer();
        string CustomerNumber = txtCustomerNumber.Text;
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerDOB = txtCustomerDOB.Text;
        string CustomerGender = txtCustomerGender.Text;
        string CustomerPostcode = txtCustomerPostcode.Text;
        string Error = "";

        Error = AnCustomer.Valid(CustomerNumber, CustomerName, CustomerEmail, CustomerDOB, CustomerGender, CustomerPostcode);
        if (Error == "")
        {
            AnCustomer.CustomerNumber = Convert.ToInt32(CustomerNumber);
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            AnCustomer.CustomerGender = CustomerGender;
            AnCustomer.CustomerPostcode = CustomerPostcode;
            Session["AnCustomer"] = AnCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerNumber;
        Boolean Found = false;
        CustomerNumber = Convert.ToInt32(txtCustomerNumber.Text);
        Found = AnCustomer.Find(CustomerNumber);
        if (Found == true)
        {
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerDOB.Text = AnCustomer.CustomerDOB.ToString();
            txtCustomerGender.Text = AnCustomer.CustomerGender;
            txtCustomerPostcode.Text = AnCustomer.CustomerPostcode;
        }
    }
}