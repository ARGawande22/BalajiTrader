using BalajiTrader.Business.Interface;
using BalajiTrader.Data;
using log4net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business
{
    public class CommonBO: ICommonBO
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonBO));

        public bool AddUpdateCategory(int categoryId, string CategoryName, string HSNCode, string Description)
        {
            return DAOFactory.CommonDAO.AddUpdateCategory(categoryId, CategoryName, HSNCode, Description);
        }

        public bool AddUpdateBrand(int brandId, int categoryId, string BrandName)
        {
            return DAOFactory.CommonDAO.AddUpdateBrand(brandId, categoryId, BrandName);
        }

        public bool AddUpdateUnit(int unitId, string UnitName)
        {
            return DAOFactory.CommonDAO.AddUpdateUnit(unitId, UnitName);
        }

        public bool AddUpdateSize(int sizeId, int categoryId, string SizeName, int unitId)
        {
            return DAOFactory.CommonDAO.AddUpdateSize(sizeId, categoryId, SizeName, unitId);
        }

        public DataSet GetCategories(int categoryId)
        {
            return DAOFactory.CommonDAO.GetCategories(categoryId);
        }

        public DataSet GetBrands(int brandId)
        {
            return DAOFactory.CommonDAO.GetBrands(brandId);
        }

        public DataSet GetUnits(int unitId)
        {
            return DAOFactory.CommonDAO.GetUnits(unitId);
        }

        public DataSet GetSizes(int sizeId)
        {
            return DAOFactory.CommonDAO.GetSizes(sizeId);
        }

        public bool EnableDisableCategory(int categoryId, string Status)
        {
            return DAOFactory.CommonDAO.EnableDisableCategory(categoryId, Status);
        }

        public bool EnableDisableBrand(int brandId, string Status)
        {
            return DAOFactory.CommonDAO.EnableDisableBrand(brandId, Status);
        }
    }
}
