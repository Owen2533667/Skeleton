using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class _1_DataEntry : System.Web.UI.Page
    {
        Int32 OrderNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderNo = Convert.ToInt32(Session["OrderNo"]);
            if (IsPostBack == false)
            {
                if (OrderNo != -1)
                {
                    DisplayOrder();
                }
            }
        }
    private void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNo);
        //display data for the record
        txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress;
        txtItemColour.Text = OrderBook.ThisOrder.ItemColour;
        txtItemPrice.Text = OrderBook.ThisOrder.ItemPrice.ToString();
        txtOrderPlaced.Text = OrderBook.ThisOrder.OrderPlaced.ToString();
        txtItemDescription.Text = OrderBook.ThisOrder.ItemDescription;
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
        chkItemAvailability.Checked = OrderBook.ThisOrder.ItemAvailability;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AOrder.Find(OrderNo);
        if (Found == true)
        {
            txtOrderNo.Text = AOrder.OrderNo.ToString();
            txtDeliveryAddress.Text = AOrder.DeliveryAddress;
            txtItemColour.Text = AOrder.ItemColour;
            txtItemPrice.Text = AOrder.ItemPrice.ToString();
            txtOrderPlaced.Text = AOrder.OrderPlaced.ToString();
            txtItemDescription.Text = AOrder.ItemDescription;
            txtStaffId.Text = AOrder.StaffId.ToString();
            chkItemAvailability.Checked = AOrder.ItemAvailability;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsOrder AOrder = new clsOrder();
        string OrderNo = txtOrderNo.Text;
        string DeliveryAddress = txtDeliveryAddress.Text;
        string ItemColour = txtItemColour.Text;
        string ItemPrice = txtItemPrice.Text;
        string OrderPlaced = txtOrderPlaced.Text;
        string ItemDescription = txtItemDescription.Text;
        string StaffId = txtStaffId.Text;
        string Error = "";

        Error = AOrder.Valid(OrderNo, ItemDescription, StaffId, DeliveryAddress, ItemColour, OrderPlaced, ItemPrice);

        if (Error == "")

        {
            AOrder.OrderNo = Convert.ToInt32(OrderNo);

            AOrder.DeliveryAddress = txtDeliveryAddress.Text;
            AOrder.ItemColour = txtItemColour.Text;
            AOrder.ItemPrice = Convert.ToDecimal(ItemPrice);
            AOrder.OrderPlaced = Convert.ToDateTime(OrderPlaced);
            AOrder.ItemDescription = txtItemDescription.Text;
            AOrder.ItemAvailability = chkItemAvailability.Checked;
            AOrder.StaffId = Convert.ToInt32(StaffId);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (this.OrderNo == -1)
            {
                OrderList.ThisOrder = AOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderNo));
                OrderList.ThisOrder = AOrder;
                OrderList.Update();

            }
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}