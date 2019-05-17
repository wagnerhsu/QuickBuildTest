using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTest
{
    [TestFixture]
    public class DemoTests
    {
        [Test]
        public void Success()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Error()
        {
            Assert.IsTrue(false);
        }
    }
}
