using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Client.Common
{
    public class Fonts
    {
        public static readonly Font DefaultFont = new Font("Cambria", 9);
        public static readonly Font DefaultBold = new Font("Cambria", 10, FontStyle.Bold);
        public static readonly Font DefaultItalic = new Font("Cambria", 9, FontStyle.Italic);
        public static readonly Font DefaultBoldItalicFont = new Font("Cambria", 9, FontStyle.Bold | FontStyle.Italic);
        public static readonly Color DefaultBackColor = Color.Azure;
        public static readonly Color DefaultForeColor = Color.Red;


    }
}
