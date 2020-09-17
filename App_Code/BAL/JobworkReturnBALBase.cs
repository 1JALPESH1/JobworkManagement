using Jobwork.DAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkReturnBALBase
/// </summary>
/// 
namespace Jobwork.BAL
{
    public abstract class JobworkReturnBALBase
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

        #region Delete Operation
        public Boolean Delete(SqlInt32 JobworkReturnID)
        {
            JobworkReturnDAL JobworkReturnDAL = new JobworkReturnDAL();
            if (JobworkReturnDAL.Delete(JobworkReturnID))
            {
                return true;
            }
            else
            {
                this.Message = JobworkReturnDAL.Message;
                return false;
            }
        }
        #endregion  Delete Operation

        #region Insert Operation
        public Boolean Insert(JobworkReturnENT entJobworkReturn)
        {
            JobworkReturnDAL dalJobworkReturn = new JobworkReturnDAL();
            if (dalJobworkReturn.Insert(entJobworkReturn))
            {
                return true;
            }
            else
            {
                this.Message = dalJobworkReturn.Message;
                return false;
            }
        }
        #endregion  Insert Operation

        #region Update Operation
        public Boolean Update(JobworkReturnENT entJobworkReturn)
        {
            JobworkReturnDAL dalJobworkReturn = new JobworkReturnDAL();
            if (dalJobworkReturn.Update(entJobworkReturn))
            {
                return true;
            }
            else
            {
                this.Message = dalJobworkReturn.Message;
                return false;
            }
        }
        #endregion  Update Operation

        #region Select Opreations

        public JobworkReturnENT SelectByPK(SqlInt32 JobworkReturnID)
        {
            JobworkReturnDAL dalJobworkReturn = new JobworkReturnDAL();
            return dalJobworkReturn.SelectByPK(JobworkReturnID);
        }

        public DataTable SelectByCustomerName(SqlInt32 CustomerID)
        {
            JobworkReturnDAL dalJobworkReturn = new JobworkReturnDAL();
            return dalJobworkReturn.SelectByCustomerName(CustomerID);
        }

        #endregion Select Opreations

       
    }
}