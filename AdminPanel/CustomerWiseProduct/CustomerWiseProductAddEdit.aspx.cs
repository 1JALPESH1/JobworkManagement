using System;
using Jobwork;
using Jobwork.BAL;
using Jobwork.ENT;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

public partial class AdminPanel_CustomerWiseProduct_CustomerWiseProductAddEdit : System.Web.UI.Page
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
            FillDropDownList(Convert.ToInt32(Session["UserID"]));
            if (Request.QueryString["CustomerWiseProductID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["CustomerWiseProductID"]));
                //lblPageHeader.Text = "CustomerWiseProduct Edit";
                CommanFiilMethod.FillDropDownListProductID(ddlProduct, Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                //lblPageHeader.Text = "CustomerWiseProduct Add";
            }

        }
    }
    #endregion Load Event

    #region FillDropDownList
    protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        CommanFiilMethod.FillDropDownListProductID(ddlProduct, Convert.ToInt32(Session["UserID"]));
    }
    private void FillDropDownList(Int32 UserID)
    {
        CommanFiilMethod.FillDropDownListCustomerID(ddlCustomer, UserID);
    }

    #endregion FillDropDownList

    #region Load Controls
    private void LoadControls(SqlInt32 CustomerWiseProductID)
    {
        CustomerWiseProductENT entCustomerWiseProduct = new CustomerWiseProductENT();
        CustomerWiseProductBAL balCustomerWiseProduct = new CustomerWiseProductBAL();

        entCustomerWiseProduct = balCustomerWiseProduct.SelectByPK(CustomerWiseProductID);

        if (!entCustomerWiseProduct.CustomerID.IsNull)
            ddlCustomer.SelectedValue = entCustomerWiseProduct.CustomerID.Value.ToString();
        if (!entCustomerWiseProduct.ProductID.IsNull)
            ddlProduct.SelectedValue = entCustomerWiseProduct.ProductID.Value.ToString();
    }
    #endregion Load Controls

    #region Button: Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region ServerSide Validation


        #endregion ServerSide Validations

        CustomerWiseProductENT entCustomerWiseProduct = new CustomerWiseProductENT();
        CustomerWiseProductBAL balCustomerWiseProduct = new CustomerWiseProductBAL();

        #region Gather Data

        if (ddlCustomer.SelectedIndex > 0)
            entCustomerWiseProduct.CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue);
        if (ddlProduct.SelectedIndex > 0)
            entCustomerWiseProduct.ProductID = Convert.ToInt32(ddlProduct.SelectedValue);

        entCustomerWiseProduct.CreationDate = DateTime.Now;

        entCustomerWiseProduct.UserID = Convert.ToInt32(Session["UserID"]);

        if (Request.QueryString["CustomerWiseProductID"] == null)
        {
            balCustomerWiseProduct.Insert(entCustomerWiseProduct);
            lblMessage.Text = "Data Insert SuccessFully";
            ClearControl();
        }
        else
        {
            entCustomerWiseProduct.CustomerWiseProductID = Convert.ToInt32(Request.QueryString["CustomerWiseProductID"]);
            balCustomerWiseProduct.Update(entCustomerWiseProduct);
            Response.Redirect("~/AdminPanel/CustomerWiseProduct/CustomerWiseProductList.aspx");
        }

        #endregion Gather Data
    }

    #endregion Button: Save


    #region Clear Control

    private void ClearControl()
    {
        ddlCustomer.SelectedIndex = 0;
        ddlProduct.SelectedIndex = 0;
        ddlCustomer.Focus();
    }

    #endregion Clear Control
}