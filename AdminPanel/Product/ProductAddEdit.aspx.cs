using Jobwork;
using Jobwork.BAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_Product_ProductAddEdit : System.Web.UI.Page
{
    #region Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect(CV.LoginPageURL);
        }
        if (!Page.IsPostBack)
        {
           
            if (Request.QueryString["ProductID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["ProductID"]));
               // lblPageHeader.Text = "Product Edit";
            }
            else
            {
               // lblPageHeader.Text = "Product Add";
            }

        }
    }
    #endregion Load Event

    #region Load Controls
    private void LoadControls(SqlInt32 ProductID)
    {
        ProductENT entProduct = new ProductENT();
        ProductBAL balProduct = new ProductBAL();

        entProduct = balProduct.SelectByPK(ProductID);

        if (!entProduct.ProductName.IsNull)
            txtProductName.Text = entProduct.ProductName.Value.ToString();
    }
    #endregion Load Controls

    #region Button: Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region ServerSide Validation


        #endregion ServerSide Validations

        ProductENT entProduct = new ProductENT();
        ProductBAL balProduct = new ProductBAL();

        #region Gather Data

        if (txtProductName.Text.Trim() != String.Empty)
            entProduct.ProductName = txtProductName.Text.Trim();

        entProduct.CreationDate = DateTime.Now;

        entProduct.UserID = Convert.ToInt32(Session["UserID"]);

        if (Request.QueryString["ProductID"] == null)
        {
            balProduct.Insert(entProduct);
            lblMessage.Text = "Data Insert SuccessFully";
            ClearControl();
        }
        else
        {
            entProduct.ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
            balProduct.Update(entProduct);
            Response.Redirect("~/AdminPanel/Product/ProductList.aspx");
        }

        #endregion Gather Data
    }

    #endregion Button: Save


    #region Clear Control

    private void ClearControl()
    {
        txtProductName.Text = "";
        txtProductName.Focus();
    }

    #endregion Clear Control
}