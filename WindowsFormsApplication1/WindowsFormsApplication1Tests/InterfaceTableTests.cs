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
    public class InterfaceTableTests
    {
        [TestMethod()]
        public void AddTestIntTable()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface1);
            Assert.IsTrue(InterfaceTable.List.Count==2);
        }
        [TestMethod()]
        public void AddTestIntTable1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface1);
            Assert.IsFalse(InterfaceTable.List.Count != 2);
        }

        [TestMethod()]
        public void DelTestIntTable()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface1);
            InterfaceTable.Del(Interface);
            InterfaceTable.Del(Interface1);
            Assert.IsTrue(InterfaceTable.List.Count == 0);
        }
        public void DelTestIntTable1()
        {
            Address IPAddress = new Address(1, 1, 1, 1);
            Address Gateway = new Address(0, 0, 0, 0);
            Interface Interface = new Interface("eth", IPAddress, Gateway);
            Interface Interface1 = new Interface("eth", IPAddress, IPAddress);
            InterfaceTable InterfaceTable = new InterfaceTable();
            InterfaceTable.Add(Interface);
            InterfaceTable.Add(Interface1);
            InterfaceTable.Del(Interface);
            InterfaceTable.Del(Interface1);
            Assert.IsFalse(InterfaceTable.List.Count!= 0);
        }
    }
}