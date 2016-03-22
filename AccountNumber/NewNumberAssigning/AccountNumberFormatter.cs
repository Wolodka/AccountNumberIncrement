using AccountNumber.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    class AccountNumberFormatter
    {
        public string GetFromInt(int number)
        {
            return String.Format(
                Strings.FORMAT_ACCOUNT_NUMBER, 
                number.ToString(Strings.DEC_CONV_FORMAT));
        }
    }
}
