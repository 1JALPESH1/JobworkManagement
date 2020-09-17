using Jobwork;
using Jobwork.BAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Product_ProductList : System.Web.UI.Page
{
    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect(CV.LoginPageURL);
        }
        if (!Page.IsPostBack)
        {
            FillProductGridView(Convert.ToInt32(Session["UserID"]));
        }

    }
    #endregion Page Load


    #region gvProduct_RowCommand
    protected void gvProduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            ProductBAL balProduct = new ProductBAL();
            if (balProduct.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillProductGridView(Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                lblMessage.Text = balProduct.Message;
            }
        }
    }
    #endregion gvProduct_RowCommand


    #region FillProductGridView

    private void FillProductGridView(SqlInt32 UserID)
    {
        ProductBAL balProduct = new ProductBAL();

        DataTable dtProduct = balProduct.SelectAll(UserID);

        if (dtProduct != null && dtProduct.Rows.Count > 0)
        {
            gvProduct.DataSource = dtProduct;
            gvProduct.DataBind();
            lblMessage.Text = "No Of Record : " + dtProduct.Rows.Count.ToString();
        }
        else
        {
            lblMessage.Text = "No Data Here";
        }
    }

    #endregion FillProductGridView



    #region  Search Button Event
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
    #endregion  Search Button Event

    #region Search
    private void Search()
    {
        SqlString ProductName = SqlString.Null;

       
        if (txtSearchProductName.Text.Trim() != "")
            ProductName = Convert.ToString(txtSearchProductName.Text.Trim());

        ProductBAL balProduct = new ProductBAL ();
        DataTable dtProduct = balProduct.Search(ProductName);
        if (dtProduct != null && dtProduct.Rows.Count > 0)
        {
            gvProduct.DataSource = dtProduct;
            gvProduct.DataBind();
        }
        else
        {
            gvProduct.DataSource = null;
            gvProduct.DataBind();
        }
    }
    #endregion  Search

    #region Clear
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtSearchProductName.Text = "";
        Search();
    }
    #endregion Clear
}