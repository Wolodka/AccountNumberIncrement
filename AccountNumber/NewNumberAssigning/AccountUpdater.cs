using AccountNumber.Res;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    class AccountUpdater
    {
        private Guid _accountId;
        private int _intNumber;
        private string _number;

        public AccountUpdater(Guid accountId, int intNumber, string number)
        {
            _accountId = accountId;
            _intNumber = intNumber;
            _number = number;
        }

        public void Update()
        {
            Entity account = new Entity(Strings.ACCOUNT_ENTITY_NAME);
            account.Id = _accountId;
            account[Strings.ACCOUNT_ATTR_INTNUMBER] = _intNumber;
            account[Strings.ACCOUNT_ATTR_NUMBER] = _number;

            IOrganizationService service = CrmService.Get();
            service.Update(account);
        }
    }
}
