using Jobwork.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDALBase
/// </summary>
namespace Jobwork.DAL
{
    public abstract class ProductDALBase : DatabaseConfig
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
            using (SqlConnection objConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objcmd = objConnection.CreateCommand())
                {
                    try
                    {
                        objConnection.Open();

                        #region Prepare Command
                        objcmd.CommandType = CommandType.StoredProcedure;
                        objcmd.CommandText = "PR_Product_Insert";
                        objcmd.Parameters.AddWithValue("@ProductName", entProduct.ProductName);
                        objcmd.Parameters.AddWithValue("@CreationDate", entProduct.CreationDate);
                        objcmd.Parameters.AddWithValue("@UserID", entProduct.UserID);

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

        public Boolean Update(ProductENT entProduct)
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
                        objcmd.CommandText = "PR_Product_UpdateByPK";
                        objcmd.Parameters.AddWithValue("@ProductID", entProduct.ProductID);
                        objcmd.Parameters.AddWithValue("@ProductName", entProduct.ProductName);
                        objcmd.Parameters.AddWithValue("@UserID", entProduct.UserID);

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

        public Boolean Delete(SqlInt32 ProductID)
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
                        objcmd.CommandText = "PR_Product_DeleteByPK";
                        objcmd.Parameters.AddWithValue("@ProductID", ProductID);

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
                        objcmd.CommandText = "PR_Product_SelectAllByUserID";
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

        public ProductENT SelectByPK(SqlInt32 ProductID)
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
                        objcmd.CommandText = "PR_Product_SelectByPK";
                        objcmd.Parameters.AddWithValue("@ProductID", ProductID.ToString());
                        #endregion Prepare Command

                        #region ReadData And SetData
                        ProductENT entProduct = new ProductENT();
                        using (SqlDataReader objSDR = objcmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["ProductName"].Equals(DBNull.Value))
                                {
                                    entProduct.ProductName = Convert.ToString(objSDR["ProductName"]);
                                }
                            }
                        }

                        return entProduct;
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

        public DataTable SelectDropDownList(SqlInt32 UserID)
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
                        objcmd.CommandText = "PR_Product_SelectDropDownList";
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

        #endregion Select Opreations
    }
}