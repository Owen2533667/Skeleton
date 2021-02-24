using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayGames();
        }
    }

    void DisplayGames()
    {
        //creates an instance of the game collection
        clsGameCollection Games = new clsGameCollection();
        //set the data source to the list of games in collection
        lstGamesList.DataSource = Games.GameList;
        //set the name of the primary key
        lstGamesList.DataValueField = "GameId";
        //Set the data field to display
        lstGamesList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGamesList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new reocrd
        Session["GameId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }
}

