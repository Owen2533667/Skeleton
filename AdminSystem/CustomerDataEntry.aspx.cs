using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNumber = Convert.ToInt32(Session["CustomerNumber"]);
        if (IsPostBack == false)
        {
            if (CustomerNumber != -1)
            {
                DisplayCustomer();
            }
        }
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
            AnCustomer.CustomerNumber = Convert.ToInt32(txtCustomerNumber.Text);
            AnCustomer.CustomerName = txtCustomerName.Text;
            AnCustomer.CustomerEmail = txtCustomerEmail.Text;
            AnCustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
            AnCustomer.CustomerGender = txtCustomerGender.Text;
            AnCustomer.CustomerPostcode = txtCustomerPostcode.Text;
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (this.CustomerNumber == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(Convert.ToInt32(CustomerNumber));
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
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

    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerNumber);
        txtCustomerNumber.Text = CustomerBook.ThisCustomer.CustomerNumber.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerDOB.Text = CustomerBook.ThisCustomer.CustomerDOB.ToString();
        txtCustomerGender.Text = CustomerBook.ThisCustomer.CustomerGender;
        txtCustomerPostcode.Text = CustomerBook.ThisCustomer.CustomerPostcode;
    }
}