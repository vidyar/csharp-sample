using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shippable.CSharpSample.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CanAdd()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(3, c.Add(1, 2));
        }

        [Test]
        public void CanSubtract()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(4, c.Subtract(5, 1));
        }

        [Test]
        public void CanMultiply()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(8, c.Subtract(4, 2));
        }
    }
}
