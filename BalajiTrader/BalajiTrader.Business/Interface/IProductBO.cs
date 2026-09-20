using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Interface
{
    interface IProductBO
    {
        bool AddUpdateProduct(int ProductId, string ProductCode, string ProductName, int CategoryId, int BrandId, int SizeId, int UnitId, string HSNCode, string Event);

        DataSet GetProducts(int productId);

        bool EnableDisableProduct(int productId, string Status);
    }
}
