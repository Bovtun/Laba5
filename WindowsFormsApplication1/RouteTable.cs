using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication1
{
    public class RouteTable : InterfaseForSave
    {
        public List<Notation> List;
        public RouteTable()
        {
            List = new List<Notation>();
        }
        public void Add(object Notation)
        {
            this.List.Add((Notation)Notation);
        }
        public void Del(object Notation)
        {
            this.List.Remove((Notation)Notation);
        }
    }
}
