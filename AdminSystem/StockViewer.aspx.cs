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
        clsGame AnGame = new clsGame();
        //get the data from the seesion object
        AnGame = (clsGame)Session["AnGame"];
        //Display the session object on the page
        Response.Write("Game Id: " + AnGame.GameId + "<br/>");
        Response.Write("Game Title: " + AnGame.GameTitle + "<br/>");
        Response.Write("Game Description: " + AnGame.GameDescription + "<br/>");
        Response.Write("Release Date: " + AnGame.ReleaseDate + "<br/>");
        Response.Write("Game Price: " + AnGame.Price + "<br/>");
        Response.Write("Stock Quantity: " + AnGame.StockQuantity + "<br/>");
        Response.Write("In Stock: " + AnGame.InStock + "<br/>");
    }
}