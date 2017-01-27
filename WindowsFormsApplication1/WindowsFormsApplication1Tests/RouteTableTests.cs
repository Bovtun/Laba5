using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class RouteTableTests
    {
        [TestMethod()]
        public void AddTestNotation()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Notation Notation = new Notation( IPAddress, Gateway,"eth",20);
            Notation Notation1 = new Notation( IPAddress, IPAddress, "eth", 20);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation1);
            Assert.IsTrue(RouteTable.List.Count == 2);
        }
        [TestMethod()]
        public void AddTestNotation1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Gateway, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, IPAddress, "eth", 20);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation1);
            Assert.IsFalse(RouteTable.List.Count != 2);
        }

        [TestMethod()]
        public void DelTestNotation()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Gateway, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, IPAddress, "eth", 20);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation1);
            RouteTable.Del(Notation);
            RouteTable.Del(Notation1);
            Assert.IsTrue(RouteTable.List.Count == 0);     
        }
        [TestMethod()]
        public void DelTestNotation1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Gateway, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, IPAddress, "eth", 20);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation1);
            RouteTable.Del(Notation);
            RouteTable.Del(Notation1);
            Assert.IsFalse(RouteTable.List.Count != 0);
        }
    }
}