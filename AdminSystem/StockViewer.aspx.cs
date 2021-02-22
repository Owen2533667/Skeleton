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
        //create a new instance of clsGame  cls
        clsGame AGame = new clsGame();
        //get the data from the seesion object
        AGame = (clsGame)Session["AGame"];
        //Display the session object on the page
        Response.Write("Game Id: " + AGame.GameId + "<br/>");
        Response.Write("Game Title: " + AGame.GameTitle + "<br/>");
        Response.Write("Game Description: " + AGame.GameDescription + "<br/>");
        Response.Write("Release Date: " + AGame.ReleaseDate + "<br/>");
        Response.Write("Game Price: " + AGame.Price + "<br/>");
        Response.Write("Stock Quantity: " + AGame.StockQuantity + "<br/>");
        Response.Write("In Stock: " + AGame.InStock + "<br/>");
    }
}