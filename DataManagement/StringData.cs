using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class StringData
    {
        public String FillIntChar(int number, int digit, String fillChar)
        {
            String numberS = number.ToString();

            while (numberS.Length < digit)
            {
                numberS = fillChar + numberS;
            }

            return numberS;
        }

        public String FillStringChar(String cadena, int digit, String fillChar)
        {
            String cadenaS = cadena;

            while (cadenaS.Length < digit)
            {
                cadenaS = fillChar + cadenaS;
            }

            return cadenaS;
        }
    }
}
