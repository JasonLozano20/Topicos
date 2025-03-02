using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public class InputValidacion
    {
        public bool OnlyNumbers(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }
        
        public bool OnlyLetters(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }
    }
}
