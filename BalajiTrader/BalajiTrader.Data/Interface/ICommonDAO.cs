using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data.Interface
{
    interface ICommonDAO
    {
        bool AddUpdateCategory(int categoryId, string CategoryName, string HSNCode, string Description);

        bool AddUpdateBrand(int brandId, int categoryId, string BrandName);
        
        bool AddUpdateUnit(int unitId, string UnitName, string Unit);

        bool AddUpdateSize(int sizeId, int categoryId, string SizeName, int unitId);

        public DataSet GetCategories(int categoryId);

        public DataSet GetBrands(int brandId);

        public DataSet GetUnits(int unitId);

        public DataSet GetSizes(int sizeId);

        bool EnableDisableCategory(int categoryId, string Status);

        bool EnableDisableBrand(int brandId, string Status);

        bool EnableDisableUnit(int unitId, string Status);

        bool EnableDisableSize(int sizeId, string Status);
    }
}
