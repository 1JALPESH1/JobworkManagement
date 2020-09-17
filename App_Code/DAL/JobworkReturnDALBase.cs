using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkReturnDALBase
/// </summary>
/// 
namespace Jobwork.DAL
{
    public abstract class JobworkReturnDALBase:DatabaseConfig
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
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_JobworkReturn_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@JobworkReturnID", JobworkReturnID);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Delete Operation


        #region Insert Operation

        public Boolean Insert(JobworkReturnENT entJobworkReturn)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_JobworkReturn_Insert";
                        objcmd.Parameters.AddWithValue("@JobworkOrderID", entJobworkReturn.JobworkOrderID);
                        objcmd.Parameters.AddWithValue("@CustomerID", entJobworkReturn.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entJobworkReturn.ProductID);
                        objcmd.Parameters.AddWithValue("@IssueGross", entJobworkReturn.IssueGross);
                        objcmd.Parameters.AddWithValue("@ReturnGross", entJobworkReturn.ReturnGross);
                        objcmd.Parameters.AddWithValue("@PendingGross", entJobworkReturn.PendingGross);
                        objcmd.Parameters.AddWithValue("@CompleteGross", entJobworkReturn.CompleteGross);
                        objcmd.Parameters.AddWithValue("@UserID", entJobworkReturn.UserID);
                        objcmd.Parameters.AddWithValue("@CreationDate", entJobworkReturn.CreationDate);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JobworkReturnENT entJobworkReturn)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_JobworkReturn_UpdateByPK";
                        objcmd.Parameters.AddWithValue("@JobworkReturnID", entJobworkReturn.JobworkReturnID);
                        objcmd.Parameters.AddWithValue("@JobWorkOrderID", entJobworkReturn.JobworkOrderID);
                        objcmd.Parameters.AddWithValue("@CustomerID", entJobworkReturn.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entJobworkReturn.ProductID);
                        objcmd.Parameters.AddWithValue("@IssueGross", entJobworkReturn.IssueGross);
                        objcmd.Parameters.AddWithValue("@ReturnGross", entJobworkReturn.ReturnGross);
                        objcmd.Parameters.AddWithValue("@PendingGross", entJobworkReturn.PendingGross);
                        objcmd.Parameters.AddWithValue("@CompleteGross", entJobworkReturn.CompleteGross);
                        objcmd.Parameters.AddWithValue("@UserID", entJobworkReturn.UserID);
                        objcmd.Parameters.AddWithValue("@CreationDate", entJobworkReturn.CreationDate);
                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();

                        return true;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }

        }

        #endregion Update Operation

        #region Select Opreations

        public JobworkReturnENT SelectByPK(SqlInt32 JobworkReturnID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_JobworkReturn_SelectByPK";
                        objcmd.Parameters.AddWithValue("@JobworkReturnID", JobworkReturnID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        JobworkReturnENT entJobworkReturn = new JobworkReturnENT();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["JobworkReturnID"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.JobworkReturnID = Convert.ToInt32(objSDR["JobworkReturnID"]);
                                }
                                if (!objSDR["JobworkOrderID"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.JobworkOrderID = Convert.ToInt32(objSDR["JobworkOrderID"]);
                                }

                                if (!objSDR["CustomerID"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.CustomerID = Convert.ToInt32(objSDR["CustomerID"]);
                                }
                                if (!objSDR["ProductID"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.ProductID = Convert.ToInt32(objSDR["ProductID"]);
                                }
                                if (!objSDR["IssueGross"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.IssueGross = Convert.ToInt32(objSDR["IssueGross"]);
                                }
                                if (!objSDR["ReturnGross"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.ReturnGross = Convert.ToInt32(objSDR["ReturnGross"]);
                                }
                                if (!objSDR["PendingGross"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.PendingGross = Convert.ToInt32(objSDR["PendingGross"]);
                                }
                                if (!objSDR["CompleteGross"].Equals(DBNull.Value))
                                {
                                    entJobworkReturn.CompleteGross = Convert.ToInt32(objSDR["CompleteGross"]);
                                }
                            }
                        }

                        return entJobworkReturn;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }
        }

      

        public DataTable SelectByCustomerName(SqlInt32 CustomerID)
        {
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_Order_SelectByCustomerName";
                        objcmd.Parameters.AddWithValue("@CustomerID", CustomerID.ToString());
                        #endregion Prepare Command
                        
                        #region ReadData And SetData
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConnection.State == ConnectionState.Open)
                            objConnection.Close();
                    }
                }
            }
        }


        #endregion Select Opreations

    }
}