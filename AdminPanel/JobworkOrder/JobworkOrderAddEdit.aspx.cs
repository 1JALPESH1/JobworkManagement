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

public partial class AdminPanel_JobworkOrder_JobworkOrderAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["JobworkOrderID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["JobworkOrderID"]));
                CommanFiilMethod.FillDropDownListCustomerWiseProductID(ddlProduct, Convert.ToInt32(ddlCustomer.SelectedValue), Convert.ToInt32(Session["UserID"]));
            }
            else
            {
            }

        }
    }
    #endregion Load Event

    #region FillDropDownList

    protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        CommanFiilMethod.FillDropDownListCustomerWiseProductID(ddlProduct, Convert.ToInt32(ddlCustomer.SelectedValue), Convert.ToInt32(Session["UserID"]));
    }
    private void FillDropDownList(Int32 UserID)
    {
        CommanFiilMethod.FillDropDownListCustomerID(ddlCustomer, UserID);
    }

    #endregion FillDropDownList

    #region Load Controls
    private void LoadControls(SqlInt32 JobworkOrderID)
    {
        JobworkOrderENT entJobworkOrder = new JobworkOrderENT();
        JobworkOrderBAL balJobworkOrder = new JobworkOrderBAL();

        entJobworkOrder = balJobworkOrder.SelectByPK(JobworkOrderID);

        if (!entJobworkOrder.CustomerID.IsNull)
            ddlCustomer.SelectedValue = entJobworkOrder.CustomerID.Value.ToString();
        if (!entJobworkOrder.ProductID.IsNull)
            ddlProduct.Text = entJobworkOrder.ProductID.Value.ToString();
        if (!entJobworkOrder.Gross.IsNull)
            txtGross.Text = entJobworkOrder.Gross.Value.ToString();
        if (!entJobworkOrder.Rate.IsNull)
            txtRate.Text = entJobworkOrder.Rate.Value.ToString();
        if (!entJobworkOrder.IssueDate.IsNull)
            txtIssueDate.Text = entJobworkOrder.IssueDate.Value.ToString();
        if (!entJobworkOrder.ReturnDate.IsNull)
            txtReturnDate.Text = entJobworkOrder.ReturnDate.Value.ToString();

    }
    #endregion Load Controls

    #region Button: Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region ServerSide Validation


        #endregion ServerSide Validations

        JobworkOrderENT entJobworkOrder = new JobworkOrderENT();
        JobworkOrderBAL balJobworkOrder = new JobworkOrderBAL();

        JobworkReturnENT entJobworkReturn = new JobworkReturnENT();
        JobworkReturnBAL balJobworkReturn = new JobworkReturnBAL();

        #region Gather Data
        if (ddlCustomer.SelectedIndex > 0)
        {
            entJobworkOrder.CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue);
            entJobworkReturn.CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue);
        }
        if (ddlProduct.SelectedIndex > 0)
        {
            entJobworkOrder.ProductID = Convert.ToInt32(ddlProduct.SelectedValue);
            entJobworkReturn.ProductID = Convert.ToInt32(ddlProduct.SelectedValue);
        }
        if (txtGross.Text.Trim() != String.Empty)
        {
            entJobworkOrder.Gross = Convert.ToInt32(txtGross.Text.Trim());
            entJobworkReturn.IssueGross = Convert.ToInt32(txtGross.Text.Trim());
            entJobworkReturn.PendingGross = Convert.ToInt32(txtGross.Text.Trim());
        }
        if (txtRate.Text.Trim() != String.Empty)
        {
            entJobworkOrder.Rate = Convert.ToInt32(txtRate.Text.Trim());
        }
        if (txtIssueDate.Text.Trim() != String.Empty)
            entJobworkOrder.IssueDate = Convert.ToDateTime(txtIssueDate.Text.Trim());
        if (txtReturnDate.Text.Trim() != String.Empty)
            entJobworkOrder.ReturnDate = Convert.ToDateTime(txtReturnDate.Text.Trim());

        entJobworkReturn.ReturnGross = 0;

        entJobworkOrder.CreationDate = DateTime.Now;
        entJobworkReturn.CreationDate = DateTime.Now;

        entJobworkOrder.UserID = Convert.ToInt32(Session["UserID"]);
        entJobworkReturn.UserID = Convert.ToInt32(Session["UserID"]);

        if (Request.QueryString["JobworkOrderID"] == null)
        {
            Int32 JobworkOrderID = balJobworkOrder.Insert(entJobworkOrder);
            if(JobworkOrderID > 0)
            entJobworkReturn.JobworkOrderID = JobworkOrderID;

            balJobworkReturn.Insert(entJobworkReturn);

            lblMessage.Text = "Data Insert SuccessFully";
            ClearControl();
        }
        else
        {
            entJobworkOrder.JobworkOrderID = Convert.ToInt32(Request.QueryString["JobworkOrderID"]);
            balJobworkOrder.Update(entJobworkOrder);
            Response.Redirect("~/AdminPanel/JobworkOrder/JobworkOrderList.aspx");
        }

        #endregion Gather Data
    }

    #endregion Button: Save


    #region Clear Control

    private void ClearControl()
    {
        ddlCustomer.SelectedIndex = -1;
        ddlProduct.SelectedIndex = 0;
        txtRate.Text = "";
        txtGross.Text = "";
        txtIssueDate.Text = "";
        txtReturnDate.Text = "";

        ddlCustomer.Focus();
    }

    #endregion Clear Control
}