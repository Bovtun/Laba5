using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApplication1
{
    class Keep
    {
        public void Add(InterfaseForSave Table,object String)
        {
            Table.Add(String);
        }
        public void Del(InterfaseForSave Table, object String)
        {
            Table.Del(String);
        }
    }
}
