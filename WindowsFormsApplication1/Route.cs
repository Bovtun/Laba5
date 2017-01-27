using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class Route
    {
        public void ShowInterface(InterfaceTable IntTab, DataTable MatrixInterface)
        {           
            DataRow WorkRow = MatrixInterface.NewRow();                    
            WorkRow[0] = IntTab.List[IntTab.List.Count - 1].Name;
            WorkRow[1] = IntTab.List[IntTab.List.Count - 1].IPAddress;
            WorkRow[2] = IntTab.List[IntTab.List.Count - 1].Gateway;
            MatrixInterface.Rows.Add(WorkRow);           
        }
        public void ShowRoute( RouteTable RouteTable, DataTable MatrixRoute)
        {
            DataRow WorkRoww = MatrixRoute.NewRow();
            WorkRoww[0] = RouteTable.List[RouteTable.List.Count - 1].IPAddress;
            WorkRoww[1] = RouteTable.List[RouteTable.List.Count - 1].Mask;
            WorkRoww[2] = RouteTable.List[RouteTable.List.Count - 1].Interface;
            WorkRoww["Metric"] =Convert.ToString(RouteTable.List[RouteTable.List.Count - 1].Metric);
            MatrixRoute.Rows.Add(WorkRoww);
        }
    }
}
