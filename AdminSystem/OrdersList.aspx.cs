using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
            DisplayOrders();

    }
    void DisplayOrders()
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        lstOrder.DataSource = AOrder.OrderList;
        lstOrder.DataValueField = "OrderNo";
        lstOrder.DataTextField = "ItemDescription";
        lstOrder.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;

        if (lstOrder.SelectedIndex != -1)
        {

            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrdersDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select an item from list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrder.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select an item to delete";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.FilterByItemDescription(txtFilter.Text);
        lstOrder.DataSource = Orders.OrderList;
        lstOrder.DataValueField = "OrderNo";
        lstOrder.DataTextField = "ItemDescription";
        lstOrder.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.FilterByItemDescription("");
        txtFilter.Text = "";
        lstOrder.DataSource = Orders.OrderList;
        lstOrder.DataValueField = "OrderNo";
        lstOrder.DataTextField = "ItemDescription";
        lstOrder.DataBind();

    }
}