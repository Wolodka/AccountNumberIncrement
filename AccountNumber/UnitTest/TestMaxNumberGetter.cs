using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.UnitTest
{
    [TestClass]
    public class TestMaxNumberGetter
    {
        [TestMethod]
        public void GetMaxAccountNumber()
        {
            CrmService.Init(new Mock.MockCrmService());

            int maxNumber = new MaxNumberGetter().Get();

            Assert.AreEqual(10, maxNumber);
        }
    }
}
