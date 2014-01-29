using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeyTest.TestThat;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace UsageExample
{
    [TestClass]
    public class MsTestCompatibility
    {
        [TestMethod]
        public void BasicFailure()
        {
            MonkeyTest.TestThat.Assert.IsTrue(false,"expecting a true value");
        }

        [TestMethod]
        public void MSTestAssertion()
        {
            Assert.IsTrue(false,"ms test message");
        }
    }
}
