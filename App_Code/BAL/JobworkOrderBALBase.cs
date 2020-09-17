using Jobwork.DAL;
using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkOrderBALBase
/// </summary>
/// 
namespace Jobwork.BAL
{
    public abstract class JobworkOrderBALBase
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
        public Int32 Insert(JobworkOrderENT entJobworkOrder)
        {
            JobworkOrderDAL JobworkOrderDAL = new JobworkOrderDAL();
            Int32 JobworkOrderID = JobworkOrderDAL.Insert(entJobworkOrder);

            if (JobworkOrderID > 0)
            {
                return JobworkOrderID;
            }
            else
            {
                this.Message = JobworkOrderDAL.Message;
                return 0;
            }
        }
        #endregion  Insert Operation

        #region Update Operation
        public Boolean Update(JobworkOrderENT entJobworkOrder)
        {
            JobworkOrderDAL JobworkOrderDAL = new JobworkOrderDAL();
            if (JobworkOrderDAL.Update(entJobworkOrder))
            {
                return true;
            }
            else
            {
                this.Message = JobworkOrderDAL.Message;
                return false;
            }
        }
        #endregion  Update Operation

        #region Delete Operation
        public Boolean Delete(SqlInt32 JobworkOrderID)
        {
            JobworkOrderDAL JobworkOrderDAL = new JobworkOrderDAL();
            if (JobworkOrderDAL.Delete(JobworkOrderID))
            {
                return true;
            }
            else
            {
                this.Message = JobworkOrderDAL.Message;
                return false;
            }
        }
        #endregion  Delete Operation

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
        {
            JobworkOrderDAL dalJobworkOrder = new JobworkOrderDAL();
            return dalJobworkOrder.SelectAll(UserID);
        }

        public JobworkOrderENT SelectByPK(SqlInt32 JobworkOrderID)
        {
            JobworkOrderDAL dalJobworkOrder = new JobworkOrderDAL();
            return dalJobworkOrder.SelectByPK(JobworkOrderID);
        }

        
        #endregion Select Opreations
    }
}