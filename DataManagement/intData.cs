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
        Random rdn = new Random();
        public int GenerateRandom(int min, int max){
            int number;
            
            number = rdn.Next(min, max + 1);
            return number;
        }

    }
}
