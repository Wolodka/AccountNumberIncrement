using AccountNumber.Res;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    class MaxNumberGetter
    {
        private EntityCollection _fetchResult;
        private Int32 _maxAccountNumber;

        public int Get()
        {
            RetrieveMaxNumber();

            if(IsResultEmpty())
                return 0;

            ExtractMaxNumberFromFetchResult();

            return _maxAccountNumber;
        }

         private void RetrieveMaxNumber()
        {
            IOrganizationService service = CrmService.Get();
            _fetchResult = service.RetrieveMultiple(
                new FetchExpression(Strings.FETCH_REQUEST_GET_MAX_ACCOUNT_NUMBER));
        }

        private bool IsResultEmpty()
        {
            return _fetchResult.Entities.Count < 1;
        }

        private void ExtractMaxNumberFromFetchResult()
        {
            AliasedValue aliasedMax = (AliasedValue)_fetchResult.Entities[0][Strings.MAX_NUMBER_ALIAS];
            _maxAccountNumber = ((Int32)aliasedMax.Value);
        }
    }
}
