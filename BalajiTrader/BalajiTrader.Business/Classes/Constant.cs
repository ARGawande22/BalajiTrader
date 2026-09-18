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
        public static readonly string assistsnce = ConfigurationManager.AppSettings.Get("AssistanceMessage");
        public static readonly string title = ConfigurationManager.AppSettings.Get("ConnectMessageTitle");

        public const string DateFormat = "dd/MM/yyyy";
        public const string DefaultDateFormat = "--/--/----";
        public const string Email = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        public const string MobileNo = @"[0-9]{10}";
        public const string Pincode = @"[0-9]{6}";
        public const string GSTNo = @"\d{2}[A-Z]{5}\d{4}[A-Z]{1}\d[Z]{1}[A-Z\d]{1}";

        public const string Namekey = "Name";
        public const string Codekey = "Code";
        public const string EmailKey = "Email";
        public const string Addrkey = "Address";
        public const string PinKey = "Pincode";
        public const string GSTKey = "GSTNo";
       
        public const char PasswordMask = '*';
        public const char PasswordBullet = '•';
        public const char PasswordDash = '-';

        public const string Namekey1 = "Name1";
    }
}
