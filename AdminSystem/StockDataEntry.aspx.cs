using System;
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
        clsGame AnGame = new clsGame();
        //capture the game Id
        AnGame.GameId = Convert.ToInt32(txtGameId.Text);
        AnGame.GameTitle = txtGameTitle.Text;
        AnGame.GameDescription = txtGameDescription.Text;
        AnGame.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text).Date;
        AnGame.Price = Convert.ToDecimal(txtPrice.Text);
        AnGame.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        AnGame.InStock = Convert.ToBoolean(chkInStock.Enabled);
        //store the attributes in the session object
        Session["AnGame"] = AnGame;
 
        //Navigates to the viewer page
        Response.Redirect("StockViewer.aspx");

        
    }
}