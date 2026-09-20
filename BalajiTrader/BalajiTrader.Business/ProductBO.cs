using BalajiTrader.Business.Interface;
using BalajiTrader.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business
{
    public class ProductBO : IProductBO
    {
        public bool AddUpdateProduct(int ProductId, string ProductCode, string ProductName, int CategoryId, int BrandId, int SizeId, int UnitId, string HSNCode, string Event)
        {
            return DAOFactory.ProductDAO.AddUpdateProduct(ProductId, ProductCode, ProductName, CategoryId, BrandId, SizeId, UnitId, HSNCode, Event);
        }

        public DataSet GetProducts(int productId)
        {
            return DAOFactory.ProductDAO.GetProducts(productId);
        }

        public bool EnableDisableProduct(int productId, string Status)
        {
            return DAOFactory.ProductDAO.EnableDisableProduct(productId, Status);
        }
    }
}
