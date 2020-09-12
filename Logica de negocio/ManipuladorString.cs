using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocio
{
    public class ManipuladorString
    {

        public static string ConvertirMayusculas(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input.ToUpper();
        }
        return input;
    }
}
}