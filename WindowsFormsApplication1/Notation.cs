using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication1
{
    public class Notation
    {
        public Address IPAddress;
        public Address Mask;
        public string Interface;
        public int Metric;
        public Notation(Address IPAddress, Address Mask, string Interface, int Metric)
        {
            this.IPAddress = IPAddress;
            this.Mask = Mask;
            this.Interface = Interface;
            this.Metric = Metric;
        }
        public static bool Equals(Notation X, Notation Y)
        {
            if (X.IPAddress.Equals(X.IPAddress, Y.IPAddress))
            {
                if (X.Mask.Equals(X.Mask, Y.Mask))
                {
                    if (X.Interface == Y.Interface)
                    {
                        if (X.Metric == Y.Metric)
                            return true;
                    }
                }
            }
            return false;
        }
        public static Notation StringToNotation(string IpaddressStr, string MaskStr, string Interface, string Metric)
        {
            char[] WorkString = new char[] { '.' };
            string[] IPSplit = IpaddressStr.Split(WorkString);
            string[] MaskSplit = MaskStr.Split(WorkString);
            Address IPAddress = new Address(Convert.ToInt32(IPSplit[0]), Convert.ToInt32(IPSplit[1]), Convert.ToInt32(IPSplit[2]), Convert.ToInt32(IPSplit[3]));
            Address Mask = new Address(Convert.ToInt32(MaskSplit[0]), Convert.ToInt32(MaskSplit[1]), Convert.ToInt32(MaskSplit[2]), Convert.ToInt32(MaskSplit[3]));
            if (Address.Check(IPAddress) && Address.Check(Mask))
            {
                Notation Notation = new Notation(IPAddress, Mask, Interface, Convert.ToInt32(Metric));
                return Notation;
            }
            return null;
        }
        public static bool Search(Notation Notation, RouteTable RouteTable)//
        {
            int i = RouteTable.List.Count;
            while (i > 0)
            {
                if (Notation.Equals(RouteTable.List[i - 1], Notation))
                    return true;
                i--;
            }
            return false;
        }
    }
}
