using BalajiTrader.Business;
using BalajiTrader.Business.Classes;
using BalajiTrader.Business.Models;
using BalajiTrader.Data;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalajiTrader.Business.Models.Common;

namespace BalajiTrader.Entities
{
    public class ProductProcess
    {
        #region Instance Variables
        private static readonly ILog log = LogManager.GetLogger(typeof(ProductProcess));

        public static List<Product> _products;
        public static Product _addProduct = null;
        #endregion

        #region Prperties
        public static List<Product> Products
        {
            get { return _products; }
        }

        public static Product AddProduct
        { 
            get { return _addProduct; }
            set { _addProduct = value; }
        }
        #endregion

        #region Methods
        #region Get Method
        public static void GetAllProduct(int productId = 0)
        {
            try
            {
                DataSet ds = BOFactory.ProductBO.GetProducts(productId);
                DataTable products = ds != null ? ds.Tables[0] : null;
                if (products != null && products.Rows.Count != 0)
                {
                    _products = new List<Product>();
                    for (int i = 0; i < products.Rows.Count; i++)
                    {
                        Product _tmpProduct = new Product
                        {
                            ProductId= Validations.ConvertToInt(products.Rows[i]["ProductId"].ToString()),
                            ProductCode= products.Rows[i]["ProductCode"].ToString(),
                            ProductName = products.Rows[i]["ProductName"].ToString(),
                            CategoryId = Validations.ConvertToInt(products.Rows[i]["CategoryId"].ToString()),
                            CategoryName = products.Rows[i]["CategoryName"].ToString(),
                            BrandId = Validations.ConvertToInt(products.Rows[i]["BrandId"].ToString()),
                            BrandName = products.Rows[i]["BrandName"].ToString(),
                            SizeId = Validations.ConvertToInt(products.Rows[i]["SizeId"].ToString()),                           
                            SizeName = products.Rows[i]["SizeName"].ToString(),
                            UnitId = Validations.ConvertToInt(products.Rows[i]["UnitId"].ToString()),
                            UnitName = products.Rows[i]["UnitName"].ToString(),
                            Unit = products.Rows[i]["UnitSymbol"].ToString(),
                            HSNCode = products.Rows[i]["HSNCode"].ToString(),
                            Status = Validations.ConvertToInt(products.Rows[i]["IsActive"].ToString()),
                            Created = Validations.ConvertDateTime(products.Rows[i]["CreatedAt"].ToString())
                        };
                        _products.Add(_tmpProduct);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting sizes. " + ex.Message);
            }
        }
        #endregion

        #region Post Method
        public static bool SaveUpdateProductDetails(string Event)
        {
            return BOFactory.ProductBO.AddUpdateProduct(AddProduct.ProductId, AddProduct.ProductCode, AddProduct.ProductName, AddProduct.CategoryId, AddProduct.BrandId, AddProduct.SizeId, AddProduct.UnitId, AddProduct.HSNCode, Event);
        }
        #endregion

        #region Put Method
        public static bool EnableDisableProduct(int ProductId, string Status)
        {
            return BOFactory.ProductBO.EnableDisableProduct(ProductId, Status);
        }
        #endregion

        #region Linq Methods
        public static List<Product> GetProducts(int categoryId = 0, int brandId = 0)
        {
            List<Product> _products = new List<Product>();
            _products = (from p in Products
                         where ((p.CategoryId == categoryId || categoryId == 0) &&
                                (p.BrandId == brandId || brandId == 0))
                         orderby p.ProductCode
                         select p).ToList();

            return _products;
        }

        public static Product ProductCopy(Product product)
        {
            Product _tmpProduct = new Product
            {
                ProductId=product.ProductId,
                CategoryId = product.CategoryId,
                CategoryName = product.CategoryName,
                BrandId = product.BrandId,
                BrandName = product.BrandName,
                SizeId = product.SizeId,
                SizeName= product.SizeName,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                UnitId = product.UnitId,
                UnitName = product.UnitName,
                Unit= product.Unit,
                HSNCode = product.HSNCode,
                Status = product.Status,
                Created = product.Created
            };
            return _tmpProduct;
        }
        #endregion
        #endregion
    }
}
