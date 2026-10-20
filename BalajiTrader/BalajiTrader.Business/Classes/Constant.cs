using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BalajiTrader.Business.Classes
{
    public class Constant
    {
        public static readonly string assistance = ConfigurationManager.AppSettings.Get("AssistanceMessage");
        public static readonly string title = ConfigurationManager.AppSettings.Get("ConnectMessageTitle");

        public const string DateFormat = "dd/MM/yyyy";
        public const string DefaultDateFormat = "--/--/----";
        public const string Email = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        public const string MobileNo = @"[0-9]{10}";
        public const string PinCode = @"[0-9]{6}";
        public const string GSTNo = @"\d{2}[A-Z]{5}\d{4}[A-Z]{1}\d[Z]{1}[A-Z\d]{1}";
        public const string OtherPAN = @"[A-Z]{3}[C,H,F,A,T,B,L,J,G,P]{1}[A-Z]{1}[0-9]{4}[A-Z]{1}";
        public const string PersonalPAN = @"[A-Z]{3}[P]{1}[A-Z]{1}[0-9]{4}[A-Z]{1}";
        public const string TANNo = @"[A-Z]{4}[0-9]{5}[A-Z]{1}";

        public const string NameKey = "Name";
        public const string CodeKey = "Code";
        public const string EmailKey = "Email";
        public const string AddressKey = "Address";
        public const string PinKey = "PinCode";
        public const string GSTKey = "GSTNo";
        public const string MobileKey = "Mobile";

        public const char PasswordMask = '*';
        public const char PasswordBullet = '•';
        public const char PasswordDash = '-';


        public const string CategoryId = "CategoryId";
        public const string Category = "Category";
        public const string BrandId = "BrandId";
        public const string BrandName = "BrandName";
        public const string SizeId = "SizeId";
        public const string SizeName = "SizeName";
        public const string UnitId = "UnitId";
        public const string UnitName = "UnitName";
        public const string Unit = "Unit";

        public const string ProductId = "ProductId";
        public const string ProductName = "ProductName";
        public const string ProductCode = "ProductCode";

        public const string VendorNameKey = "VendorName";
        public const string PANKey = "PAN";

    }
}
