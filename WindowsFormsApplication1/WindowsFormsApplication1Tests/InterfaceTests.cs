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
    public class InterfaceTests
    {
        [TestMethod()]
        public void EqualsTestInt()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth0", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth0", IPAddress, Gateway);
            Assert.IsTrue(Interface.Equals(Interface,Interface1));
        }
        [TestMethod()]
        public void EqualsTestInt1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth0", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth1", IPAddress, IPAddress);
            Assert.IsFalse(Interface.Equals(Interface, Interface1));
        }
        [TestMethod()]
        public void StringToInterfaceTest()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = Interface.StringToInterface("eth", "1.1.1.1", "0.0.0.0");
            Assert.IsTrue(Interface.Equals(Interface, Interface1));
        }
        [TestMethod()]
        public void SearchTest()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface1);
            Assert.IsTrue(Interface.Search(Interface,InterfaceTable));
        }
        [TestMethod()]
        public void SearchTest1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface);
            Assert.IsFalse(Interface.Search(Interface1, InterfaceTable));
        }
    }
}