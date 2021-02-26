using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 GameId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the Id number of the game to be deleted from the session object
        GameId = Convert.ToInt32(Session["GameId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the game collection
        clsGameCollection GameCollection = new clsGameCollection();
        //find the record to delete
        GameCollection.ThisGame.Find(GameId);
        //delete the record
        GameCollection.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}