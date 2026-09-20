using BalajiTrader.Data.Interface;
using BalajiTrader.DataAccess;
using log4net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data
{
    public class ProductDAO :BaseDAO, IProductDAO
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ProductDAO));

        public bool AddUpdateProduct(int ProductId, string ProductCode, string ProductName, int CategoryId, int BrandId, int SizeId, int UnitId, string HSNCode, string Event)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@product_Id",ProductId),
                    new SqlParameter("@productCode",ProductCode),
                    new SqlParameter("@productName",ProductName),
                    new SqlParameter("@categoryId",CategoryId),
                    new SqlParameter("@brandId",BrandId),
                    new SqlParameter("@sizeId",SizeId),
                    new SqlParameter("@unitId",UnitId),
                    new SqlParameter("@hsnCode",HSNCode)
                };

                ExecuteNonQuery(StoreProcedures.AddUpdateProduct, parameters);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return false;
            }

        }

        public DataSet GetProducts(int productId)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@product_Id",productId)
                };

                return ExecuteDataset(StoreProcedures.SelProduct, parameters);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message.ToString());
                return null;
            }
        }

        public bool EnableDisableProduct(int productId, string Status)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@productId",productId),
                    new SqlParameter("@status",Status)
                };

                ExecuteNonQuery(StoreProcedures.del_Product, parameters);
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
