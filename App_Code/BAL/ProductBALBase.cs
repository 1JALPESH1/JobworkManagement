using Jobwork.DAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductBALBase
/// </summary>
namespace Jobwork.BAL
{
    public abstract class ProductBALBase
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
        public Boolean Insert(ProductENT entProduct)
        {
            ProductDAL ProductDAL = new ProductDAL();
            if (ProductDAL.Insert(entProduct))
            {
                return true;
            }
            else
            {
                this.Message = ProductDAL.Message;
                return false;
            }
        }
        #endregion  Insert Operation

        #region Update Operation
        public Boolean Update(ProductENT entProduct)
        {
            ProductDAL ProductDAL = new ProductDAL();
            if (ProductDAL.Update(entProduct))
            {
                return true;
            }
            else
            {
                this.Message = ProductDAL.Message;
                return false;
            }
        }
        #endregion  Update Operation

        #region Delete Operation
        public Boolean Delete(SqlInt32 ProductID)
        {
            ProductDAL ProductDAL = new ProductDAL();
            if (ProductDAL.Delete(ProductID))
            {
                return true;
            }
            else
            {
                this.Message = ProductDAL.Message;
                return false;
            }
        }
        #endregion  Delete Operation

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
        {
            ProductDAL dalProduct = new ProductDAL();
            return dalProduct.SelectAll(UserID);
        }

        public ProductENT SelectByPK(SqlInt32 ProductID)
        {
            ProductDAL dalProduct = new ProductDAL();
            return dalProduct.SelectByPK(ProductID);
        }

        public DataTable SelectDropDownList(SqlInt32 UserID)
        {
            ProductDAL dalProduct = new ProductDAL();
            return dalProduct.SelectDropDownList(UserID);
        }

        #endregion Select Opreations

    }
}