using System;
using Jobwork.BAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;
using System.Data;
using Jobwork;

public partial class AdminPanel_CustomerWiseProduct_CustomerWiseProductList : System.Web.UI.Page
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
            FillCustomerWiseProductGridView(Convert.ToInt32(Session["UserID"]));
        }

    }
    #endregion Page Load

    #region gvCustomerWiseProduct_RowCommand
    protected void gvCustomerWiseProduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            CustomerWiseProductBAL balCustomerWiseProduct = new CustomerWiseProductBAL();
            if (balCustomerWiseProduct.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillCustomerWiseProductGridView(Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                lblMessage.Text = balCustomerWiseProduct.Message;
            }
        }
    }
    #endregion gvCustomerWiseProduct_RowCommand


    #region FillCustomerWiseProductGridView

    private void FillCustomerWiseProductGridView(SqlInt32 UserID)
    {
        CustomerWiseProductBAL balCustomerWiseProduct = new CustomerWiseProductBAL();

        DataTable dtCustomerWiseProduct = balCustomerWiseProduct.SelectAll(UserID);

        if (dtCustomerWiseProduct != null && dtCustomerWiseProduct.Rows.Count > 0)
        {
            gvCustomerWiseProduct.DataSource = dtCustomerWiseProduct;
            gvCustomerWiseProduct.DataBind();
            lblMessage.Text = "No Of Record : " + dtCustomerWiseProduct.Rows.Count.ToString();
        }
        else
        {
            lblMessage.Text = "No Data Here";
        }
    }

    #endregion FillCustomerWiseProductGridView
}