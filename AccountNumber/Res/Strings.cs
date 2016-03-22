using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.Res
{
    class Strings
    {
        public const string FETCH_REQUEST_GET_MAX_ACCOUNT_NUMBER = @" 
                <fetch distinct='false' mapping='logical' aggregate='true'> 
                    <entity name='account'> 
                       <attribute name='new_intnumber' alias='intnumber_max' aggregate='max' /> 
                    </entity> 
                </fetch>";

        public const string MAX_NUMBER_ALIAS = "intnumber_max";

        public const string FORMAT_ACCOUNT_NUMBER = "ACC{0, 6}-SL";
        public const string DEC_CONV_FORMAT = "D6";

        public const string ACCOUNT_ENTITY_NAME = "account";
        public const string ACCOUNT_ATTR_ID = "accountid";
        public const string ACCOUNT_ATTR_NUMBER = "accountnumber";
        public const string ACCOUNT_ATTR_INTNUMBER = "new_intnumber";

        public const string PLUGIN_EVENT_CREATE = "Create";
        public const string PLUGIN_TARGET_PARAM_NAME = "Target";
    }
}
