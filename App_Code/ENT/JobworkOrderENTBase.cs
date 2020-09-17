using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkOrderENTBase
/// </summary>
/// 
namespace Jobwork.ENT
{
    public abstract class JobworkOrderENTBase
    {
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

        protected SqlInt32 _Gross;
        public SqlInt32 Gross
        {
            get
            {
                return _Gross;
            }
            set
            {
                _Gross = value;
            }
        }

        protected SqlInt32 _Rate;
        public SqlInt32 Rate
        {
            get
            {
                return _Rate;
            }
            set
            {
                _Rate = value;
            }
        }

        protected SqlDateTime _IssueDate;
        public SqlDateTime IssueDate
        {
            get
            {
                return _IssueDate;
            }
            set
            {
                _IssueDate = value;
            }
        }

        protected SqlDateTime _ReturnDate;
        public SqlDateTime ReturnDate
        {
            get
            {
                return _ReturnDate;
            }
            set
            {
                _ReturnDate = value;
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