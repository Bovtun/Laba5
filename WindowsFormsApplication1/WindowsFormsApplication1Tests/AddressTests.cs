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
    public class AddressTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Address A = new Address(1, 1, 1, 1);
            Address B = new Address(1, 1, 1, 1);
            bool flag = A.Equals(A, B);
            Assert.IsTrue(flag);
        }
        [TestMethod()]
        public void EqualsTest1()
        {
            Address A = new Address(1, 1, 1, 1);
            Address B = new Address(1, 1, 1, 2);
            bool flag = A.Equals(A, B);
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Address A = new Address(1, 1, 1, 1);
            string str = A;
            Assert.IsTrue(str=="1.1.1.1");
        }
        [TestMethod()]
        public void ToStringTest1()
        {
            Address A = new Address(1, 1, 1, 1);
            string str = A;
            Assert.IsFalse(str!= A);
        }

        [TestMethod()]
        public void CheckTest()
        {
            Address A = new Address(1, 1, 1, 1);
            Assert.IsTrue(Address.Check(A));
        }
        [TestMethod()]
        public void CheckTest1()
        {
            Address A = new Address(1, 256, 1, 1);
            Assert.IsFalse(Address.Check(A));
        }
    }
}