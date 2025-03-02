using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ValidatorRFC
    {
        public bool RFCValido(string rfc)
        {
            rfc = RFCCorregido(rfc);
            return Regex.IsMatch(rfc, @"^[a-zA-Z]{4}\d{6}[A-Z0-9]{2,3}$");
           
            

        }
        public string RFCCorregido(string rfc)
        {
            if(string.IsNullOrEmpty(rfc))
                return string.Empty;
            return rfc.Trim().ToUpper();
        }
    }
}
