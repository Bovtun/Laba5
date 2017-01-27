using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class RouteTests
    {
        [TestMethod()]
        public void ShowInterfaceTest()
        {
            DataTable MatrixInterface = new DataTable("MatrixInterface");
            MatrixInterface.Columns.Add("Name", typeof(String));
            MatrixInterface.Columns.Add("IPAddress", typeof(String));
            MatrixInterface.Columns.Add("Gateway", typeof(String));
            Route Route = new Route();
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            Route.ShowInterface(InterfaceTable, MatrixInterface);
            Assert.IsTrue(MatrixInterface.Rows.Count==1);
        }

        [TestMethod()]
        public void ShowRouteTest()
        {
            DataTable MatrixRoute = new DataTable("MatrixRoute");
            MatrixRoute.Columns.Add("IPAddress", typeof(String));
            MatrixRoute.Columns.Add("Mask", typeof(String));
            MatrixRoute.Columns.Add("Interface", typeof(String));
            MatrixRoute.Columns.Add("Metric", typeof(String));
            Route Route = new Route();
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Gateway, "eth", 20);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            Route.ShowRoute(RouteTable, MatrixRoute);
            Assert.IsTrue(MatrixRoute.Rows.Count == 1);
        }
    }
}