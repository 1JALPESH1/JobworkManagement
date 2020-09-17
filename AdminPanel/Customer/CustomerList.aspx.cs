using Jobwork;
using Jobwork.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Customer_CustomerList : System.Web.UI.Page
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
            FillCustomerGridView(Convert.ToInt32(Session["UserID"]));
        }

    }
    #endregion Page Load

    #region gvCustomer_RowCommand
    protected void gvCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            CustomerBAL balCustomer = new CustomerBAL();
            if (balCustomer.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillCustomerGridView(Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                lblMessage.Text = balCustomer.Message;
            }
        }
    }
    #endregion gvCustomer_RowCommand

    #region FillCustomerGridView

    private void FillCustomerGridView(SqlInt32 UserID)
    {
        CustomerBAL balCustomer = new CustomerBAL();

        DataTable dtCustomer = balCustomer.SelectAll(UserID);

        if (dtCustomer != null && dtCustomer.Rows.Count > 0)
        {
            gvCustomer.DataSource = dtCustomer;
            gvCustomer.DataBind();
            lblMessage.Text = "No Of Record : " + dtCustomer.Rows.Count.ToString();
        }
        else
        {
            lblMessage.Text = "No Data Here";
        }
    }

    #endregion FillCustomerGridView

    #region  Search Button Event
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
    #endregion  Search Button Event

    #region Search
    private void Search()
    {
        SqlString CustomerName = SqlString.Null;
        SqlString MobileNumber = SqlString.Null;
        SqlString EmailAddress = SqlString.Null;


        if (txtSearchCustomerName.Text.Trim() != "")
            CustomerName = Convert.ToString(txtSearchCustomerName.Text.Trim());

        if (txtSerachEmail.Text.Trim() != "")
            EmailAddress = Convert.ToString(txtSerachEmail.Text.Trim());

        if (txtSearchMobileNumber.Text.Trim() != "")
            MobileNumber = Convert.ToString(txtSearchMobileNumber.Text.Trim());

        CustomerBAL balCustomer = new CustomerBAL();
        DataTable dtCustomer = balCustomer.Search(CustomerName,MobileNumber,EmailAddress);
        if (dtCustomer != null && dtCustomer.Rows.Count > 0)
        {
            gvCustomer.DataSource = dtCustomer;
            gvCustomer.DataBind();
        }
        else
        {
            gvCustomer.DataSource = null;
            gvCustomer.DataBind();
        }
    }
    #endregion  Search

    #region Clear
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtSearchCustomerName.Text = "";
        txtSerachEmail.Text = "";
        txtSearchMobileNumber.Text = "";
        Search();
    }
    #endregion Clear
}