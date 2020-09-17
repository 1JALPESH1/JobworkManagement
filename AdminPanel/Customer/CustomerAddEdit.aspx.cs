
using Jobwork;
using Jobwork.BAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Panel_Customer_CustomerAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["CustomerID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["CustomerID"]));
                //lblPageHeader.Text = "Customer Edit";
            }
            else
            {
                //lblPageHeader.Text = "Customer Add";
            }

        }
    }
    #endregion Load Event

    #region Load Controls
    private void LoadControls(SqlInt32 CustomerID)
    {
        CustomerENT entCustomer = new CustomerENT();
        CustomerBAL balCustomer = new CustomerBAL();

        entCustomer = balCustomer.SelectByPK(CustomerID);

        if (!entCustomer.CustomerName.IsNull)
            txtCustomerName.Text = entCustomer.CustomerName.Value.ToString();
        if (!entCustomer.EmailID.IsNull)
            txtEmailAddress.Text = entCustomer.EmailID.Value.ToString();
        if (!entCustomer.MobileNo.IsNull)
            txtMobileNo.Text = entCustomer.MobileNo.Value.ToString();
        if (!entCustomer.Address.IsNull)
            txtAddress.Text = entCustomer.Address.Value.ToString();

    }
    #endregion Load Controls

    #region Button: Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region ServerSide Validation


        #endregion ServerSide Validations

        CustomerENT entCustomer = new CustomerENT();
        CustomerBAL balCustomer = new CustomerBAL();

        #region Gather Data

        if (txtCustomerName.Text.Trim() != String.Empty)
            entCustomer.CustomerName = txtCustomerName.Text.Trim();
        if (txtEmailAddress.Text.Trim() != String.Empty)
            entCustomer.EmailID = txtEmailAddress.Text.Trim();
        if (txtMobileNo.Text.Trim() != String.Empty)
            entCustomer.MobileNo = txtMobileNo.Text.Trim();
        if (txtAddress.Text.Trim() != String.Empty)
            entCustomer.Address = txtAddress.Text.Trim();

        entCustomer.CreationDate = DateTime.Now;

        entCustomer.UserID = Convert.ToInt32(Session["UserID"]);

        if (Request.QueryString["CustomerID"] == null)
        {
            balCustomer.Insert(entCustomer);
            lblMessage.Text = "Data Insert SuccessFully";
            ClearControl();
        }
        else
        {
            entCustomer.CustomerID = Convert.ToInt32(Request.QueryString["CustomerID"]);
            balCustomer.Update(entCustomer);
            Response.Redirect("~/AdminPanel/Customer/CustomerList.aspx");
        }

        #endregion Gather Data
    }

    #endregion Button: Save


    #region Clear Control

    private void ClearControl()
    {
        txtCustomerName.Text = "";
        txtEmailAddress.Text = "";
        txtMobileNo.Text = "";
        txtAddress.Text = "";
        txtCustomerName.Focus();
    }

    #endregion Clear Control
}