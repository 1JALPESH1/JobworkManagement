using Jobwork;
using Jobwork.BAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JobworkOrder_JobworkOrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Page Load

        if (Session["UserID"] == null)
        {
            Response.Redirect(CV.LoginPageURL);
        }
        if (!Page.IsPostBack)
        {
            FillJobworkOrderGridView(Convert.ToInt32(Session["UserID"]));
        }

    }
        #endregion Page Load

    #region gvJobworkOrder_RowCommand
    protected void gvJobworkOrder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JobworkOrderBAL balJobworkOrder = new JobworkOrderBAL();

            if (balJobworkOrder.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillJobworkOrderGridView(Convert.ToInt32(Session["UserID"]));
            }
            else
            {
                lblMessage.Text = balJobworkOrder.Message;
            }
        }
    }
    #endregion gvJobworkOrder_RowCommand


    #region FillJobworkOrderGridView

    private void FillJobworkOrderGridView(SqlInt32 UserID)
    {
        JobworkOrderBAL balJobworkOrder = new JobworkOrderBAL();

        DataTable dtJobworkOrder = balJobworkOrder.SelectAll(UserID);

        if (dtJobworkOrder != null && dtJobworkOrder.Rows.Count > 0)
        {
            gvJobworkOrder.DataSource = dtJobworkOrder;
            gvJobworkOrder.DataBind();
            lblMessage.Text = "No Of Record : " + dtJobworkOrder.Rows.Count.ToString();
        }
        else
        {
            lblMessage.Text = "No Data Here";
            gvJobworkOrder.DataSource = null;
            gvJobworkOrder.DataBind();
        }
    }

    #endregion FillJobworkOrderGridView
}
