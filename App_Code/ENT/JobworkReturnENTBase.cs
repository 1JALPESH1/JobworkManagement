using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkReturnENTBase
/// </summary>
/// 
namespace Jobwork.ENT
{
    public abstract class JobworkReturnENTBase
    {
        protected SqlInt32 _JobworkReturnID;
        public SqlInt32 JobworkReturnID
        {
            get
            {
                return _JobworkReturnID;
            }
            set
            {
                _JobworkReturnID = value;
            }
        }
        protected SqlInt32 _JobworkOrderID;
        public SqlInt32 JobworkOrderID
        {
            get
            {
                return _JobworkOrderID;
            }
            set
            {
                _JobworkOrderID = value;
            }
        }

        protected SqlInt32 _CustomerID;
        public SqlInt32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }

        protected SqlInt32 _ProductID;
        public SqlInt32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                _ProductID = value;
            }
        }

        protected SqlInt32 _IssueGross;
        public SqlInt32 IssueGross
        {
            get
            {
                return _IssueGross;
            }
            set
            {
                _IssueGross = value;
            }
        }

        protected SqlInt32 _ReturnGross;
        public SqlInt32 ReturnGross
        {
            get
            {
                return _ReturnGross;
            }
            set
            {
                _ReturnGross = value;
            }
        }

        protected SqlInt32 _PendingGross;
        public SqlInt32 PendingGross
        {
            get
            {
                return _PendingGross;
            }
            set
            {
                _PendingGross = value;
            }
        }

        protected SqlInt32 _CompleteGross;
        public SqlInt32 CompleteGross
        {
            get
            {
                return _CompleteGross;
            }
            set
            {
                _CompleteGross = value;
            }
        }




        protected SqlInt32 _UserID;
        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }

        protected SqlDateTime _CreationDate;
        public SqlDateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
            }
        }

        protected SqlDateTime _ModifiedDate;
        public SqlDateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                _ModifiedDate = value;
            }
        }

    }
}