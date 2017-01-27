using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication1
{
    public class InterfaceTable:InterfaseForSave
    {
        public List<Interface> List;
        public InterfaceTable()
        {
            List = new List<Interface>();
        }
        public void Add(object Interface)
        {
            this.List.Add((Interface)Interface);
        }
        public void Del(object Interface)
        {
            this.List.Remove((Interface)Interface);
        }
    }
}
