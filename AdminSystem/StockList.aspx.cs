﻿using System;
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


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 GameId;
        //if a record has been selected from the list
        if (lstGamesList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            GameId = Convert.ToInt32(lstGamesList.SelectedValue);
            //store the data in the session object
            Session["GameId"] = GameId;
            //Redirect to StockConfirmDelete.aspx
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key va;ue of the record to be edited
        Int32 GameId;
        //if a record has been selected from the list
        if (lstGamesList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            GameId = Convert.ToInt32(lstGamesList.SelectedValue);
            //store the data in the session object
            Session["GameId"] = GameId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the game collection
        clsGameCollection Games = new clsGameCollection();
        Games.ReportByGameTitle(txtFilter.Text);
        lstGamesList.DataSource = Games.GameList;
        //set the name of the primary key
        lstGamesList.DataValueField = "GameId";
        //set the name of the field to display
        lstGamesList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGamesList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the game collection
        clsGameCollection Games = new clsGameCollection();
        Games.ReportByGameTitle("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstGamesList.DataSource = Games.GameList;
        //set the name of the primary key
        lstGamesList.DataValueField = "GameId";
        //set the name of the field to display
        lstGamesList.DataTextField = "GameTitle";
        //bind the data to the list
        lstGamesList.DataBind();
    }
}

