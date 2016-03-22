using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.Res
{
    class ExceptionMessages
    {
        public const string WRONG_ENTITY_OR_EVENT = "This plugin should be fired on create of account only.";
        public const string NO_TARGET_ENTITY = "No Target Entity Image found";
        public const string EXCEPTION_OCCURED_IN_PLUGIN = "An error occurred in the Account on Create plug-in.";
    }
}
