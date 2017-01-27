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
    public class NotationTests
    {
        [TestMethod()]
        public void EqualsTestNotation()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, Mask, "eth", 20);
            Assert.IsTrue(Notation.Equals(Notation,Notation1));
        }
        [TestMethod()]
        public void EqualsTestNotation1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, Mask, "eth", 10);
            Assert.IsFalse(Notation.Equals(Notation, Notation1));
        }
        [TestMethod()]
        public void StringToNotationTest()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = Notation.StringToNotation("1.1.1.1", "0.0.0.0", "eth", "20");
            Assert.IsTrue(Notation.Equals(Notation,Notation1));
        }
        [TestMethod()]
        public void StringToNotationTest1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = Notation.StringToNotation("1.1.1.1", "0.0.0.2", "eth", "20");
            Assert.IsFalse(Notation.Equals(Notation,Notation1));
        }
        [TestMethod()]
        public void SearchTestNotation()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, Mask, "eth", 10);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation1);
            Assert.IsTrue(Notation.Search(Notation,RouteTable));
        }
        [TestMethod()]
        public void SearchTestNotation1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Mask = new Address(0, 0, 0, 0);
            Notation Notation = new Notation(IPAddress, Mask, "eth", 20);
            Notation Notation1 = new Notation(IPAddress, Mask, "eth", 10);
            RouteTable RouteTable = new RouteTable();
            RouteTable.Add(Notation);
            RouteTable.Add(Notation);
            Assert.IsFalse(Notation.Search(Notation1, RouteTable));
        }
    }
}