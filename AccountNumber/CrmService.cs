using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    class CrmService
    {
        private static IOrganizationService _service;

        public static void Init(IOrganizationService service)
        {
            _service = service;
        }

        public static IOrganizationService Get()
        {
            return _service;
        }
    }
}
