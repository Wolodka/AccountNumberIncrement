using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.UnitTest
{
    [TestClass]
    public class TestCrmOrganizationService
    {
        [TestMethod]
        public void GetCrmOrganizationService()
        {
            CrmService.Init(new Mock.MockCrmService());
            IOrganizationService service = CrmService.Get();

            Assert.IsNotNull(service);
        }
    }
}
