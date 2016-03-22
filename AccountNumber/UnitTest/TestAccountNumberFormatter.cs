using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.UnitTest
{
    [TestClass]
    public class TestAccountNumberFormatter
    {
        [TestMethod]
        public void FormatNumber()
        {
            Assert.AreEqual("ACC000003-SL", new AccountNumberFormatter().GetFromInt(3));
            Assert.AreEqual("ACC001567-SL", new AccountNumberFormatter().GetFromInt(1567));
        }
    }
}
