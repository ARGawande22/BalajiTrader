using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Classes
{
    public class Validations
    {
        private static Regex _regex;

        /// <summary>
        /// check and convert value to integer  Or long if not null.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static int ConvertToInt(string Value)
        {
            return !String.IsNullOrEmpty(Value) ? Convert.ToInt32(Value) : 0;
        }

        public static decimal ConvertToDecimal(string Value)
        {
            return !String.IsNullOrEmpty(Value) ? Convert.ToDecimal(Value) : 0;
        }

        public static long ConvertToLong(string Value)
        {
            return !String.IsNullOrEmpty(Value) ? Convert.ToInt64(Value) : 0;
        }

        public static DateTime? ConvertToDateTime(string Value)
        {
            return !String.IsNullOrEmpty(Value) ? Convert.ToDateTime(Value) : null;
        }

        public static DateTime ConvertDateTime(string Value)
        {
            return !String.IsNullOrEmpty(Value) ? Convert.ToDateTime(Value) : DateTime.MinValue;
        }

        public static string ConvertStringDate(DateTime? Value)
        {
            return Value != null ? Convert.ToDateTime(Value).ToString("dd-MM-yyyy") : "";
        }

        public static string ConvertDefaultStringDate(DateTime? Value)
        {
            return Value != null ? Convert.ToDateTime(Value).ToString(Constant.DateFormat) : "";
        }
        
        /// <summary>
        /// check entered email is valid or not
        /// </summary>
        /// <param name="EmailId"></param>
        /// <returns></returns>
        public static bool ValidateEmail(string EmailId)
        {
            _regex = new Regex(Constant.Email);
            return _regex.IsMatch(EmailId);
        }

        /// <summary>
        /// Check entered Mobile No is 10 digit valid or not
        /// </summary>
        /// <param name="MobileNo"></param>
        /// <returns></returns>
        public static bool ValidateMobileNo(string MobileNo)
        {
            _regex = new Regex(Constant.MobileNo);
            return _regex.IsMatch(MobileNo);
        }


        /// <summary>
        /// Check entered PinCode is 6 digit valid or not
        /// </summary>
        /// <param name="PinCode"></param>
        /// <returns></returns>
        public static bool ValidatePincode(string PinCode)
        {
            _regex = new Regex(Constant.Pincode);
            return _regex.IsMatch(PinCode);
        }

        /// <summary>
        /// Check entered GSTNo is valid or not
        /// </summary>
        /// <param name="GSTNo"></param>
        /// <returns></returns>
        public static bool ValidateGSTNo(string GSTNo)
        {
            _regex = new Regex(Constant.GSTNo);
            return _regex.IsMatch(GSTNo);
        }

        /// <summary>
        /// Get the value in UpperCase
        /// </summary>
        /// <param name="Value"></param>
        /// <returns>string</returns>
        public static string ConvertTpUpperCase(string Value)
        {
            return Value.ToUpper();
        }

    }
}
