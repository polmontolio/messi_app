using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class intData
    {
        public int GenerateRandom(int min, int max){
            int number;
            Random rdn = new Random();
            number = rdn.Next(min, max + 1);
            return number;
        }

    }
}
