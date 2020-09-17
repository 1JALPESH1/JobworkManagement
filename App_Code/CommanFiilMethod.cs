using Jobwork.BAL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for CommanFiilMethod
/// </summary>
/// 
namespace Jobwork
{
    public class CommanFiilMethod
    {

        #region FillDropDownList CustomerID

        public static void FillDropDownListCustomerID(DropDownList ddl, SqlInt32 UserID)
        {
            CustomerBAL balCustomer = new CustomerBAL();
            ddl.DataSource = balCustomer.SelectDropDownList(UserID);
            ddl.DataTextField = "CustomerName";
            ddl.DataValueField = "CustomerID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("---Select Customer---", "-99"));
        }
        #endregion FillDropDownList CustomerID

        #region FillDropDownList ProductID

        public static void FillDropDownListProductID(DropDownList ddl, SqlInt32 UserID)
        {
            ProductBAL balProduct = new ProductBAL();
            ddl.DataSource = balProduct.SelectDropDownList(UserID);
            ddl.DataTextField = "ProductName";
            ddl.DataValueField = "ProductID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("---Select Product---", "-99"));
        }
        #endregion FillDropDownList CustomerWiseProductID

        #region FillDropDownList CustomerWiseProductID

        public static void FillDropDownListCustomerWiseProductID(DropDownList ddl, SqlInt32 CustomerID,SqlInt32 UserID )
        {
            CustomerWiseProductBAL balCustomerWiseProduct = new CustomerWiseProductBAL();
            ddl.DataSource = balCustomerWiseProduct.SelectDropDownList(CustomerID,UserID);
            ddl.DataTextField = "ProductName";
            ddl.DataValueField = "ProductID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("---Select Product---", "-99"));
        }
        #endregion FillDropDownList CustomerWiseProductID

    }
}