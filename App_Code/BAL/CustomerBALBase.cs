using Jobwork.DAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerBALBase
/// </summary>
namespace Jobwork.BAL
{
    public abstract class CustomerBALBase
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
        public Boolean Insert(CustomerENT entCustomer)
        {
            CustomerDAL CustomerDAL = new CustomerDAL();
            if (CustomerDAL.Insert(entCustomer))
            {
                return true;
            }
            else
            {
                this.Message = CustomerDAL.Message;
                return false;
            }
        }
        #endregion  Insert Operation

        #region Update Operation
        public Boolean Update(CustomerENT entCustomer)
        {
            CustomerDAL CustomerDAL = new CustomerDAL();
            if (CustomerDAL.Update(entCustomer))
            {
                return true;
            }
            else
            {
                this.Message = CustomerDAL.Message;
                return false;
            }
        }
        #endregion  Update Operation

        #region Delete Operation
        public Boolean Delete(SqlInt32 CustomerID)
        {
            CustomerDAL CustomerDAL = new CustomerDAL();
            if (CustomerDAL.Delete(CustomerID))
            {
                return true;
            }
            else
            {
                this.Message = CustomerDAL.Message;
                return false;
            }
        }
        #endregion  Delete Operation

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
        {
            CustomerDAL dalCustomer = new CustomerDAL();
            return dalCustomer.SelectAll(UserID);
        }

        public CustomerENT SelectByPK(SqlInt32 CustomerID)
        {
            CustomerDAL dalCustomer = new CustomerDAL();
            return dalCustomer.SelectByPK(CustomerID);
        }

        public DataTable SelectDropDownList(SqlInt32 UserID)
        {
            CustomerDAL dalCustomer = new CustomerDAL();
            return dalCustomer.SelectDropDownList(UserID);
        }

        #endregion Select Opreations

    }
}