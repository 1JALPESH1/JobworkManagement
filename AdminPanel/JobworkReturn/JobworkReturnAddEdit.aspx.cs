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

public partial class AdminPanel_JobworkReturn_JobworkReturnAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["JobworkReturnID"] != null)
            {
                CommanFiilMethod.FillDropDownListCustomerID(ddlCustomer, Convert.ToInt32(Session["UserID"]));
            }
            else
            {
            }

        }
    }
    #endregion Load Event

    #region FillDropDownList


    private void FillDropDownList(Int32 UserID)
    {
        CommanFiilMethod.FillDropDownListCustomerID(ddlCustomer, UserID);
    }

    #endregion FillDropDownList

    #region gvJobworkReturn_RowCommand
    protected void gvJobworkReturn_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JobworkReturnBAL balJobworkReturn = new JobworkReturnBAL();
           

            if (balJobworkReturn.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                    FillJobworkReturnGridView(Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                lblMessage.Text = balJobworkReturn.Message;
            }
        }
    }
    #endregion gvJobworkReturn_RowCommand



    #region FillJobworkReturnGridView

    private void FillJobworkReturnGridView(SqlInt32 CustomerID)
    {
        JobworkReturnBAL balJobworkReturn = new JobworkReturnBAL();

        DataTable dtJobworkReturn = balJobworkReturn.SelectByCustomerName(CustomerID);

        if (dtJobworkReturn != null && dtJobworkReturn.Rows.Count > 0)
        {
            gvJobworkReturn.DataSource = dtJobworkReturn;
            gvJobworkReturn.DataBind();
            lblMessage.Text = "No Of Record : " + dtJobworkReturn.Rows.Count.ToString();
        }
        else
        {
           
            lblMessage.Text = "No Data Here";
            gvJobworkReturn.DataSource = null;
            gvJobworkReturn.DataBind();
        }
    }

    #endregion FillJobworkReturnGridView


    protected void btnShow_Click(object sender, EventArgs e)
    {
        btnSave.Visible = true;
        hlCancel.Visible = true;
        FillJobworkReturnGridView(Convert.ToInt32(ddlCustomer.SelectedValue));
    }


    #region 15.0 Save Button Event
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Page.Validate();
        if (Page.IsValid)
        {
            try
            {
                JobworkReturnBAL balJobworkReturn = new JobworkReturnBAL();
                JobworkReturnENT entJobworkReturn = new JobworkReturnENT();

                #region 15.1 Validate Fields

                String ErrorMsg = String.Empty;

                if (ddlCustomer.SelectedIndex <= 0 || ddlCustomer.SelectedValue == "-99")
                    ErrorMsg += " Order Name";

                if (ErrorMsg != String.Empty)
                {
                    lblMessage.Text = ErrorMsg;

                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                #endregion 15.1 Validate Fields

                
                #region 15.2 Gather Data
                foreach (GridViewRow row in gvJobworkReturn.Rows)
                {
                    //entJobworkReturn.JobworkReturnID = 23;
                    entJobworkReturn.JobworkReturnID = Convert.ToInt32(((HiddenField)row.Cells[6].FindControl("hfJobworkReturnID")).Value);
                    entJobworkReturn = balJobworkReturn.SelectByPK(entJobworkReturn.JobworkReturnID);
                    
                    TextBox txt = (TextBox)row.Cells[6].FindControl("txtCompleteGross");
                    string txtCompleteGross = txt.Text;

                    if (txtCompleteGross.Trim() != String.Empty)
                        entJobworkReturn.CompleteGross = Convert.ToInt32(txtCompleteGross);
                    else
                        entJobworkReturn.CompleteGross = 0;
                  //  entJobworkReturn.JobworkOrderID = Convert.ToInt32((txtCompleteGross.FindControl("hfJobWorkOrderID") as HiddenField).Value);
                    //if (txtCompleteGross.Text.Trim() != String.Empty)
                    //    entJobworkReturn.CompleteGross = Convert.ToInt32(txtCompleteGross.Text);

                    //entJobworkReturn.JobworkOrderID = Convert.ToInt32(((HiddenField)gvJobworkReturn.SelectedRow.FindControl("hfJobWorkOrderID")).Value);
                    //entJobworkReturn.JobworkOrderID = entJobworkReturn.JobworkOrderID;

                    //if (ddlCustomer.SelectedIndex > 0)
                    //    entJobworkReturn.CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue);

                    //entJobworkReturn.ProductID = entJobworkReturn.ProductID;


                    //entJobworkReturn.IssueGross = entJobworkReturn.IssueGross;

                    //entJobworkReturn.ReturnGross = entJobworkReturn.ReturnGross;

                    //entJobworkReturn.PendingGross = entJobworkReturn.PendingGross;

                    entJobworkReturn.UserID = Convert.ToInt32(Session["UserID"]);

                    entJobworkReturn.CreationDate = DateTime.Now;

                    balJobworkReturn.Update(entJobworkReturn);


                }

                #endregion 15.2 Gather Data

                #region 15.3 Insert,Update,Copy
                if (Page.RouteData.Values["JobworkReturnID"] == null)
                {
                    FillJobworkReturnGridView(Convert.ToInt32(ddlCustomer.SelectedValue));
                }
              
                #endregion 15.3 Insert,Update,Copy

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                //lblMessage.CssClass = CSSClass.alertdanger;
                lblMessage.ForeColor = Color.Red;

            }
        }
    }

    #endregion 15.0 Save Button Event


    //protected void txtCompleteGross_TextChanged(object sender, EventArgs e)
    //{
        
    //}


}