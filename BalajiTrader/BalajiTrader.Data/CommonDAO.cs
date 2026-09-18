using BalajiTrader.Data.Interface;
using BalajiTrader.DataAccess;
using log4net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data
{
    public class CommonDAO : BaseDAO, ICommonDAO
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonDAO));

        public bool AddUpdateCategory(int categoryId, string CategoryName, string HSNCode, string Description)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@categoryId",categoryId),
                    new SqlParameter("@categoryName",CategoryName),
                    new SqlParameter("@hsnCode",HSNCode),
                    new SqlParameter("@description",Description)
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateCategory, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool AddUpdateBrand(int brandId, int categoryId, string BrandName)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@brandId",brandId),
                    new SqlParameter("@categoryId",categoryId),
                    new SqlParameter("@brandName",BrandName)
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateBrand, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool AddUpdateUnit(int unitId, string UnitName, string Unit)
        {
            try
            {                
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@unitId",unitId),
                    new SqlParameter("@unitName",UnitName),
                    new SqlParameter("@unit",Unit)
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateUnit, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool AddUpdateSize(int sizeId, int categoryId, string SizeName, int unitId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@sizeId",sizeId),
                    new SqlParameter("@categoryId",categoryId),
                    new SqlParameter("@sizeName",SizeName),
                    new SqlParameter("@unitId",unitId),
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateSize, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public DataSet GetCategories(int categoryId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@categoryId",categoryId)
                };

                return ExecuteDataset(StoreProcedures.SelCategories, parameters);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return null;
            }
        }

        public DataSet GetBrands(int brandId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@brandId",brandId)
                };

                return ExecuteDataset(StoreProcedures.SelBrands, parameters);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return null;
            }
        }

        public DataSet GetUnits(int unitId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@unitId",unitId)
                };

                return ExecuteDataset(StoreProcedures.SelUnits, parameters);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return null;
            }
        }

        public DataSet GetSizes(int sizeId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@sizeId",sizeId)
                };

                return ExecuteDataset(StoreProcedures.SelSizes, parameters);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return null;
            }
        }

        public bool EnableDisableCategory(int categoryId, string Status)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@categoryId",categoryId),
                    new SqlParameter("@status",Status)
                };

                ExecuteNonQuery(StoreProcedures.del_Category, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool EnableDisableBrand(int brandId, string Status)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@brandId",brandId),
                    new SqlParameter("@status",Status)
                };

                ExecuteNonQuery(StoreProcedures.del_Brand, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool EnableDisableUnit(int unitId, string Status)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@unitId",unitId),
                    new SqlParameter("@status",Status)
                };

                ExecuteNonQuery(StoreProcedures.del_Unit, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }

        public bool EnableDisableSize(int sizeId, string Status)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@sizeId",sizeId),
                    new SqlParameter("@status",Status)
                };

                ExecuteNonQuery(StoreProcedures.del_Size, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }
        }
    }
}
