using BalajiTrader.Business;
using BalajiTrader.Business.Classes;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BalajiTrader.Business.Models.Common;

namespace BalajiTrader.Entities
{
    public static class CommonProcess
    {
        #region Instance Variables
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonProcess));

        public static List<Category> _categories;
        public static List<Brand> _brands;
        public static List<Units> _units;
        public static List<Sizes> _sizes;

        public static Category _addCategory = null;
        #endregion

        #region Prperties
        public static List<Category> Categories
        {
            get { return _categories; }
        }

        public static List<Brand> Brands
        {
            get { return _brands; }
        }

        public static List<Units> Units
        {
            get { return _units; }
        }

        public static List<Sizes> Sizes
        {
            get { return _sizes; }
        }

        public static Category AddCategory
        {
            get { return _addCategory; }
            set { _addCategory = value; }
        }
        #endregion

        #region Methods
        #region Post Method
        public static bool AddUpdateCategory(int categoryId, string CategoryName, string HSNCode, string Description)
        {
            return BOFactory.CommonBO.AddUpdateCategory(categoryId, CategoryName, HSNCode, Description);
        }

        public static bool AddUpdateBrand(int brandId, int categoryId, string BrandName)
        {
            return BOFactory.CommonBO.AddUpdateBrand(brandId, categoryId, BrandName);
        }

        public static bool AddUpdateUnit(int unitId, string UnitName)
        {
            return BOFactory.CommonBO.AddUpdateUnit(unitId, UnitName);
        }

        public static bool AddUpdateSize(int sizeId, int categoryId, string SizeName, int unitId)
        {
            return BOFactory.CommonBO.AddUpdateSize(sizeId, categoryId, SizeName, unitId);
        }
        #endregion

        #region Get Method
        public static void GetAllCategories(int categoryId=0)
        {
            try
            {
                DataSet ds = BOFactory.CommonBO.GetCategories(categoryId);
                DataTable categories = ds != null ? ds.Tables[0] : null;
                if (categories != null && categories.Rows.Count != 0)
                {
                    _categories = new List<Category>();
                    for (int i = 0; i < categories.Rows.Count; i++)
                    {
                        Category _tmpCategories = new Category
                        {
                            CategoryId = Validations.ConvertToInt(categories.Rows[i]["CategoryId"].ToString()),
                            CategoryName = categories.Rows[i]["CategoryName"].ToString(),
                            HSNCode = categories.Rows[i]["HSNCode"].ToString(),
                            Description = categories.Rows[i]["Description"].ToString(),
                            Status = Validations.ConvertToInt(categories.Rows[i]["IsActive"].ToString()),
                            Created = Validations.ConvertDateTime(categories.Rows[i]["CreatedAt"].ToString())
                        };
                        _categories.Add(_tmpCategories);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting Categories. " + ex.Message);
            }
        }

        public static void GetAllBrands(int brandId)
        {
            try
            {
                DataSet ds = BOFactory.CommonBO.GetBrands(brandId);
                DataTable brands = ds != null ? ds.Tables[0] : null;
                if (brands != null && brands.Rows.Count != 0)
                {
                    _brands = new List<Brand>();
                    for (int i = 0; i < brands.Rows.Count; i++)
                    {
                        Brand _tmpbrands = new Brand
                        {
                            BrandId = Validations.ConvertToInt(brands.Rows[i]["BrandId"].ToString()),
                            CategoryId = Validations.ConvertToInt(brands.Rows[i]["CategoryId"].ToString()),
                            CategoryName = brands.Rows[i]["CategoryName"].ToString(),
                            BrandName = brands.Rows[i]["BrandName"].ToString(),
                            Status = Validations.ConvertToInt(brands.Rows[i]["IsActive"].ToString()),
                            Created = Validations.ConvertDateTime(brands.Rows[i]["CreatedAt"].ToString())
                        };
                        _brands.Add(_tmpbrands);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting Brands. " + ex.Message);
            }
        }

        public static void GetAllUnits(int unitId)
        {
            try
            {
                DataSet ds = BOFactory.CommonBO.GetUnits(unitId);
                DataTable units = ds != null ? ds.Tables[0] : null;
                if (units != null && units.Rows.Count != 0)
                {
                    _units = new List<Units>();
                    for (int i = 0; i < units.Rows.Count; i++)
                    {
                        Units _tmpunits = new Units
                        {
                            UnitId = Validations.ConvertToInt(units.Rows[i]["UnitId"].ToString()),
                            UnitName = units.Rows[i]["UnitName"].ToString(),
                            Unit = units.Rows[i]["UnitSymbol"].ToString(),
                            Status = Validations.ConvertToInt(units.Rows[i]["IsActive"].ToString()),
                            Created = Validations.ConvertDateTime(units.Rows[i]["CreatedAt"].ToString())
                        };
                        _units.Add(_tmpunits);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting units. " + ex.Message);
            }
        }

        public static void GetAllSizes(int sizeId)
        {
            try
            {
                DataSet ds = BOFactory.CommonBO.GetSizes(sizeId);
                DataTable sizes = ds != null ? ds.Tables[0] : null;
                if (sizes != null && sizes.Rows.Count != 0)
                {
                    _sizes = new List<Sizes>();
                    for (int i = 0; i < sizes.Rows.Count; i++)
                    {
                        Sizes _tmpsizes = new Sizes
                        {
                            SizeId = Validations.ConvertToInt(sizes.Rows[i]["SizeId"].ToString()),
                            CategoryId = Validations.ConvertToInt(sizes.Rows[i]["CategoryId"].ToString()),
                            CategoryName = sizes.Rows[i]["CategoryName"].ToString(),
                            SizeName = sizes.Rows[i]["SizeName"].ToString(),
                            UnitId = Validations.ConvertToInt(sizes.Rows[i]["UnitId"].ToString()),
                            UnitName = sizes.Rows[i]["UnitName"].ToString(),
                            Status = Validations.ConvertToInt(sizes.Rows[i]["IsActive"].ToString()),
                            Created = Validations.ConvertDateTime(sizes.Rows[i]["CreatedAt"].ToString())
                        };
                        _sizes.Add(_tmpsizes);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info("Error getting sizes. " + ex.Message);
            }
        }
        #endregion

        #region Linq Methods
        public static List<Category> GetCategories(int categoryId = 0)
        {
            List<Category> _categories = new List<Category>();

            _categories = (from c in Categories
                           where ((c.CategoryId == categoryId || categoryId==0))
                      orderby c.CategoryId
                      select c).ToList();

            return _categories;
        }

        public static Category CategoryCopy(Category category)
        {
            Category _tmpcategory = new Category
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                HSNCode = category.HSNCode,
                Description = category.Description,
                Status = category.Status,
                Created = category.Created
            };
            return _tmpcategory;
        }
        #endregion
        #endregion



    }
}
