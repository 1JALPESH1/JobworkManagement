using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobworkOrderDALBase
/// </summary>
/// 
namespace Jobwork.DAL
{
    public abstract class JobworkOrderDALBase:DatabaseConfig
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
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_JobworkOrder_Insert";
                        objcmd.Parameters.AddWithValue("@JobworkOrderID", SqlDbType.Int).Direction = ParameterDirection.Output;
                        objcmd.Parameters.AddWithValue("@CustomerID", entJobworkOrder.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entJobworkOrder.ProductID);
                        objcmd.Parameters.AddWithValue("@Gross", entJobworkOrder.Gross);
                        objcmd.Parameters.AddWithValue("@Rate", entJobworkOrder.Rate);
                        objcmd.Parameters.AddWithValue("@IssueDate", entJobworkOrder.IssueDate);
                        objcmd.Parameters.AddWithValue("@ReturnDate", entJobworkOrder.ReturnDate);
                        objcmd.Parameters.AddWithValue("@UserID", entJobworkOrder.UserID);
                        objcmd.Parameters.AddWithValue("@CreationDate", entJobworkOrder.CreationDate);

                        #endregion Prepare Command

                        #region ReadData And SetData
                        objcmd.ExecuteNonQuery();
                        Int32 JobworkOrderID = Convert.ToInt32(objcmd.Parameters["@JobworkOrderID"].Value.ToString());
                        return JobworkOrderID;
                        #endregion ReadData And SetData

                    }
                    catch (SqlException Sqlex)
                    {
                        Message = Sqlex.Message.ToString();
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.Message.ToString();
                        return 0;
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

        public Boolean Update(JobworkOrderENT entJobworkOrder)
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
                        objcmd.CommandText = "PR_JobworkOrder_UpdateByPK";
                        objcmd.Parameters.AddWithValue("@JobworkOrderID", entJobworkOrder.JobworkOrderID);
                        objcmd.Parameters.AddWithValue("@CustomerID", entJobworkOrder.CustomerID);
                        objcmd.Parameters.AddWithValue("@ProductID", entJobworkOrder.ProductID);
                        objcmd.Parameters.AddWithValue("@Gross", entJobworkOrder.Gross);
                        objcmd.Parameters.AddWithValue("@Rate", entJobworkOrder.Rate);
                        objcmd.Parameters.AddWithValue("@IssueDate", entJobworkOrder.IssueDate);
                        objcmd.Parameters.AddWithValue("@ReturnDate", entJobworkOrder.ReturnDate);
                        objcmd.Parameters.AddWithValue("@UserID", entJobworkOrder.UserID);
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

        #region Delete Operation

        public Boolean Delete(SqlInt32 JobworkOrderID)

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
                        objcmd.CommandText = "PR_JobworkOrder_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@JobworkOrderID", JobworkOrderID);

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

        #region Select Opreations

        public DataTable SelectAll(SqlInt32 UserID)
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
                        objcmd.CommandText = "PR_JobworkOrder_SelectAllByUserID";
                        objcmd.Parameters.AddWithValue("@UserID", UserID.ToString());
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

        public JobworkOrderENT SelectByPK(SqlInt32 JobworkOrderID)
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
                        objcmd.CommandText = "PR_JobworkOrder_SelectByPK";
                        objcmd.Parameters.AddWithValue("@JobworkOrderID", JobworkOrderID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        JobworkOrderENT entJobworkOrder = new JobworkOrderENT();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["CustomerID"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.CustomerID = Convert.ToInt32(objSDR["CustomerID"]);
                                }
                                if (!objSDR["ProductID"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.ProductID = Convert.ToInt32(objSDR["ProductID"]);
                                }
                                if (!objSDR["Gross"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.Gross = Convert.ToInt32(objSDR["Gross"]);
                                }
                                if (!objSDR["Rate"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.Rate = Convert.ToInt32(objSDR["Rate"]);
                                }
                                if (!objSDR["IssueDate"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.IssueDate = Convert.ToDateTime(objSDR["IssueDate"]);
                                }
                                if (!objSDR["ReturnDate"].Equals(DBNull.Value))
                                {
                                    entJobworkOrder.ReturnDate = Convert.ToDateTime(objSDR["ReturnDate"]);
                                }
                            }
                        }

                        return entJobworkOrder;
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