﻿using System;
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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsGame
        clsGame AGame = new clsGame();
        //capture the data for each field
        string GameId = txtGameId.Text;
        string GameTitle = txtGameTitle.Text;
        string GameDescription = txtGameDescription.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string Price = txtPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string Error = "";
        //Validate the data
        Error = AGame.Valid(GameId, GameTitle, GameDescription, Price, ReleaseDate, StockQuantity);

        if (Error == "")
        {
            //capture the game Id
            AGame.GameId = Convert.ToInt32(txtGameId.Text);
            AGame.GameTitle = txtGameTitle.Text;
            AGame.GameDescription = txtGameDescription.Text;
            AGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text).Date;
            AGame.Price = Convert.ToDecimal(txtPrice.Text);
            AGame.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            AGame.InStock = chkInStock.Checked;
            //create a new instance of the game collection
            clsGameCollection GameList = new clsGameCollection();
            //set the ThisGame property
            GameList.ThisGame = AGame;
            //add the new record
            GameList.Add();
            //redirect back to the listpage
            Response.Redirect("StockList.aspx");

            //store the attributes in the session object
            //Session["AGame"] = AGame;
            //redirects to the viewer page
            //Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //Display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the game class
        clsGame AGame = new clsGame();
        //variable to store the primary key
        Int32 GameId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        GameId = Convert.ToInt32(txtGameId.Text);
        //find the record
        Found = AGame.Find(GameId);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtGameId.Text = AGame.GameId.ToString();
            txtGameTitle.Text = AGame.GameTitle;
            txtGameDescription.Text = AGame.GameDescription;
            txtReleaseDate.Text = AGame.ReleaseDate.ToString();
            txtPrice.Text = AGame.Price.ToString();
            txtStockQuantity.Text = AGame.StockQuantity.ToString();

        }
    }
}