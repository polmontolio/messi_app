using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkUtilities
{
    public class Machine
    {

        public string getHostname()
        {

            return Dns.GetHostName(); 
        }

        public string getMAC()
        {
            String digitos;
            String digitosConcat;
            int i = 0;

            String firstMacAddress = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up 
                && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
                && !nic.Description.Contains("Virtual"))
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();

            digitosConcat = firstMacAddress.Substring(0, 2);


            for (i = 2; i < firstMacAddress.Length; i+=2)
            {

                digitos = firstMacAddress.Substring(i, 2);
                digitosConcat = digitosConcat + "-" + digitos;
                
            }

            firstMacAddress = digitosConcat;
            return firstMacAddress;
        }
    }

    
}
