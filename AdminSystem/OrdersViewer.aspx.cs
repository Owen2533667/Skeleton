using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        AOrder = (clsOrder)Session["AOrder"];
        Response.Write("OrderNo: " + AOrder.OrderNo + "<br/>");
        Response.Write("DeliveryAddress: " + AOrder.DeliveryAddress + "<br/>");
        Response.Write("ItemColour: " + AOrder.ItemColour + "<br/>");
        Response.Write("ItemPrice: " + AOrder.ItemPrice + "<br/>");
        Response.Write("OrderPlaced: " + AOrder.OrderPlaced + "<br/>");
        Response.Write("ItemDescription: " + AOrder.ItemDescription + "<br/>");
        Response.Write("StaffID: " + AOrder.StaffId + "<br/>");
    }
}
