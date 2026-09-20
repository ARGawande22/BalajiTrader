using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Models
{
    public class Product
    {
        #region local Veriable
        private int _productId;
        private int _categoryId;
        private string _categoryName;
        private int _brandId;
        private string _brandName;
        private int _sizeId;
        private string _sizeName;
        private string _productCode;
        private string _productName;
        private int _unitId;
        private string _unitName;
        private string _unit;
        private string _hsnCode;        
        private int _status;
        private DateTime _created;
        #endregion

        #region Properties 
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
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

        public int BrandId
        {
            get { return _brandId; }
            set { _brandId = value; }
        }

        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        public int SizeId
        {
            get { return _sizeId; }
            set { _sizeId = value; }
        }

        public string SizeName
        {
            get { return _sizeName; }
            set { _sizeName = value; }
        }

        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
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

        public string HSNCode
        {
            get { return _hsnCode; }
            set { _hsnCode = value; }
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
