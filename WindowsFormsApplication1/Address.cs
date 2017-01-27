using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Address
    {
        public int Sell1;
        public int Sell2;
        public int Sell3;
        public int Sell4;
        public Address (int Sell1, int Sell2, int Sell3, int Sell4)
        {     
            this.Sell1 = Sell1;
            this.Sell2 = Sell2;
            this.Sell3 = Sell3;
            this.Sell4 = Sell4;            
        }
        public bool Equals(Address X,Address Y)
        {
            if (X.Sell1 == Y.Sell1)
            {
                if (X.Sell2 == Y.Sell2)
                {
                    if (X.Sell3 == Y.Sell3)
                    {
                        if (X.Sell4 == Y.Sell4)
                            return true;
                    }
                }
            }
            return false;
        }
        public static implicit operator string(Address addr)
        {
            return addr.ToString();
        }
        public override string ToString()
        {
            string WorkRow = "";
            WorkRow = "." + WorkRow.Insert(0, Convert.ToString(this.Sell4));
            WorkRow = "." + WorkRow.Insert(0, Convert.ToString(this.Sell3));
            WorkRow = "." + WorkRow.Insert(0, Convert.ToString(this.Sell2));
            WorkRow = WorkRow.Insert(0, Convert.ToString(this.Sell1));
            return WorkRow;
        }
        public static bool Check(Address Address)
        {
            int i = 0;
            bool Flag = true;
            string str = Address;
            string[] split = str.Split('.');
            while (i != 4)
            {
                if (Convert.ToInt32(split[i]) > 255)
                {
                    Flag = false;
                }
                i++;
            }
            return Flag;
        }
    }
}
