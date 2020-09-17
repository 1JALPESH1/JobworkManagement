using Jobwork.DAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerWiseProductBALBase
/// </summary>/// 
namespace Jobwork.BAL
{
    public abstract class CustomerWiseProductBALBase
    {
        #region Local Variable

        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variable

        #region Insert Operation
        public Boolean Insert(CustomerWiseProductENT entCustomerWiseProduct)
        {
            CustomerWiseProductDAL CustomerWiseProductDAL = new CustomerWiseProductDAL();
            if (CustomerWiseProductDAL.Insert(entCustomerWiseProduct))
            {
                return true;
            }
            else
            {
                this.Message = CustomerWiseProductDAL.Message;
                return false;
            }
        }
        #endregion  Insert Operation

        #region Update Operation
        public Boolean Update(CustomerWiseProductENT entCustomerWiseProduct)
        {
            CustomerWiseProductDAL CustomerWiseProductDAL = new CustomerWiseProductDAL();
            if (CustomerWiseProductDAL.Update(entCustomerWiseProduct))
            {
                return true;
            }
            else
            {
                this.Message = CustomerWiseProductDAL.Message;
                return false;
            }
        }
        #endregion  Update Operation

        #region Delete Operation
        public Boolean Delete(SqlInt32 CustomerWiseProductID)
        {
            CustomerWiseProductDAL CustomerWiseProductDAL = new CustomerWiseProductDAL();
            if (CustomerWiseProductDAL.Delete(CustomerWiseProductID))
            {
                return true;
            }
            else
            {
                this.Message = CustomerWiseProductDAL.Message;
                return false;
            }
        }
        #endregion  Delete Operation

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
        {
            CustomerWiseProductDAL dalCustomerWiseProduct = new CustomerWiseProductDAL();
            return dalCustomerWiseProduct.SelectAll(UserID);
        }

        public CustomerWiseProductENT SelectByPK(SqlInt32 CustomerWiseProductID)
        {
            CustomerWiseProductDAL dalCustomerWiseProduct = new CustomerWiseProductDAL();
            return dalCustomerWiseProduct.SelectByPK(CustomerWiseProductID);
        }

        public DataTable SelectDropDownList(SqlInt32 CustomerID, SqlInt32 UserID)
        {
            CustomerWiseProductDAL dalCustomerWiseProduct = new CustomerWiseProductDAL();
            return dalCustomerWiseProduct.SelectDropDownList(CustomerID,UserID);
        }

        #endregion Select Opreations

    }
}