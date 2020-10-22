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
            String firstMacAddress = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();

            for (int i = 0; i < firstMacAddress.Length; i++)
            {

            }
            
            return firstMacAddress;
        }
    }

    
}
