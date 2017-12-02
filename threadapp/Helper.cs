using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace threadapp
{
    public class Helper
    {
        public decimal convierteDec(string dec)
        {
            decimal res;
            res = (string.IsNullOrEmpty(dec)) ? 0 : decimal.Parse(dec);
            return res;
        }

        public decimal convierteDecAll(string dec1, string dec2, string dec3)
        {
            decimal res;
            res = convierteDec(dec1) + convierteDec(dec2) + convierteDec(dec3);
            return res;
        }
    }
}
