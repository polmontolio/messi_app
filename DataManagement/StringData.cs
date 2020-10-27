using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class StringData
    {

        public String FillIntZeros(int number, int digit, String fillChar)
        {
            String numberS = number.ToString();

            while (numberS.Length < digit)
            {
                numberS = fillChar + numberS;
            }

            return numberS;
        }
    }
}
