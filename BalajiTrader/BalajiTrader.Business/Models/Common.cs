using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Models
{
    public class Common
    {
        public class Category
        {
            #region local Veriable
            private int _categoryId;
            private string _categoryName;
            private string _hsnCode;
            private string _description;
            private int _status;
            private DateTime _created;
            #endregion

            #region Properties 
            public int CategoryId
            {
                get { return _categoryId; }
                set { _categoryId = value; }
            }

            public string CategoryName
            {
                get { return _categoryName; }
                set { _categoryName = value; }
            }

            public string HSNCode
            {
                get { return _hsnCode; }
                set { _hsnCode = value; }
            }

            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }

            public int Status
            {
                get { return _status; }
                set { _status = value; }
            }

            public DateTime Created
            {
                get { return _created; }
                set { _created = value; }
            }
            #endregion
        }


        public class Brand
        {
            #region local Veriable
            private int _brandId;
            private int _categoryId;
            private string _categoryName;
            private string _brandName;
            private int _status;
            private DateTime _created;
            #endregion

            #region Properties 
            public int BrandId
            {
                get { return _brandId; }
                set { _brandId = value; }
            }

            public int CategoryId
            {
                get { return _categoryId; }
                set { _categoryId = value; }
            }

            public string CategoryName
            {
                get { return _categoryName; }
                set { _categoryName = value; }
            }

            public string BrandName
            {
                get { return _brandName; }
                set { _brandName = value; }
            }

            public int Status
            {
                get { return _status; }
                set { _status = value; }
            }

            public DateTime Created
            {
                get { return _created; }
                set { _created = value; }
            }
            #endregion
        }


        public class Units
        {
            #region local Veriable
            private int _unitId;
            private string _unitName;
            private string _unit;
            private int _status;
            private DateTime _created;
            #endregion

            #region Properties 
            public int UnitId
            {
                get { return _unitId; }
                set { _unitId = value; }
            }

            public string UnitName
            {
                get { return _unitName; }
                set { _unitName = value; }
            }

            public string Unit
            {
                get { return _unit; }
                set { _unit = value; }
            }

            public int Status
            {
                get { return _status; }
                set { _status = value; }
            }

            public DateTime Created
            {
                get { return _created; }
                set { _created = value; }
            }
            #endregion
        }


        public class Sizes
        {
            #region local Veriable
            private int _sizeId;
            private int _categoryId;
            private string _categoryName;
            private string _sizeName;
            private int _unitId;
            private string _unitName;
            private string _unit;
            private int _status;
            private DateTime _created;
            #endregion

            #region Properties 
            public int SizeId
            {
                get { return _sizeId; }
                set { _sizeId = value; }
            }

            public int CategoryId
            {
                get { return _categoryId; }
                set { _categoryId = value; }
            }

            public string CategoryName
            {
                get { return _categoryName; }
                set { _categoryName = value; }
            }

            public string SizeName
            {
                get { return _sizeName; }
                set { _sizeName = value; }
            }

            public int UnitId
            {
                get { return _unitId; }
                set { _unitId = value; }
            }

            public string UnitName
            {
                get { return _unitName; }
                set { _unitName = value; }
            }

            public string Unit
            {
                get { return _unit; }
                set { _unit = value; }
            }

            public int Status
            {
                get { return _status; }
                set { _status = value; }
            }

            public DateTime Created
            {
                get { return _created; }
                set { _created = value; }
            }
            #endregion
        }
    }
}
