using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Data
{
    public class StoreProcedures
    {
        //Category
        internal static readonly string AddUpdateCategory = "save_UpdateCategory";
        internal static readonly string SelCategories = "sel_Category";
        internal static readonly string del_Category = "del_Category";

        //Brand
        internal static readonly string AddUpdateBrand = "save_UpdateBrand";
        internal static readonly string SelBrands = "sel_Brand";
        internal static readonly string del_Brand = "del_Brand";

        //Unit
        internal static readonly string AddUpdateUnit = "save_UpdateUnit";
        internal static readonly string SelUnits = "sel_Unit";
        internal static readonly string del_Unit = "del_Unit";

        //Size
        internal static readonly string AddUpdateSize = "save_UpdateSize";
        internal static readonly string SelSizes = "sel_Size";
        internal static readonly string del_Size = "del_Size";

        //Product
        internal static readonly string AddUpdateProduct = "save_UpdateProduct";
        internal static readonly string SelProduct = "sel_Product";
        internal static readonly string del_Product = "del_Product";

        //Vendor
        internal static readonly string AddUpdateVendor = "save_UpdateVendor";
        internal static readonly string SelVendor = "sel_Vendor";
        internal static readonly string del_Vendor = "del_Vendor";

    }
}
