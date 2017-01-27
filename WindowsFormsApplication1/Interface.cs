using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication1
{
    public class Interface
    {
        public string Name; 
        public Address IPAddress;
        public Address Gateway;
        public Interface(string Name,Address IPAddress,Address Gateway)
        {
            this.Name = Name;
            this.IPAddress = IPAddress;
            this.Gateway = Gateway;
        }
        public  bool Equals(Interface X, Interface Y)
        {
            if(X.Name==Y.Name)
            {
                if (X.IPAddress.Equals(X.IPAddress, Y.IPAddress))
                {
                    if (X.IPAddress.Equals(X.Gateway, Y.Gateway))
                        return true;
                }
            }
            return false;
        }
        public static Interface StringToInterface(string name, string ipaddress, string gateway)
        {
            char[] WorkString = new char[] { '.' };
            string[] IPSplit = ipaddress.Split(WorkString);
            string[] GatewaySplit = gateway.Split(WorkString);
            Address IPAddress = new Address(Convert.ToInt32(IPSplit[0]), Convert.ToInt32(IPSplit[1]), Convert.ToInt32(IPSplit[2]), Convert.ToInt32(IPSplit[3]));
            Address GatewayAddress = new Address(Convert.ToInt32(GatewaySplit[0]), Convert.ToInt32(GatewaySplit[1]), Convert.ToInt32(GatewaySplit[2]), Convert.ToInt32(GatewaySplit[3]));
            if (Address.Check(IPAddress) && Address.Check(GatewayAddress))
            {
                Interface Int = new Interface(name, IPAddress, GatewayAddress);
                return Int;
            }
            return null;
        }
        public static bool Search(Interface Int, InterfaceTable InterfaceTable)
        {
            int i = InterfaceTable.List.Count;
            while (i > 0)
            {
                if (Int.Equals(InterfaceTable.List[i - 1], Int))
                    return true;
                i--;
            }
            return false;
        }
    }
}
