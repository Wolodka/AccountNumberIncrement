using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    static class NewNumberAssigner
    {
        private static int _maxAccountIntNumber;

        public static void Assign(Guid accountId)
        {
            try
            {
                LockData();
                GetCurrentMaxNumber();
                CreateNewNumber();
                UpdateAccount(accountId);
            }
            catch
            {

            }
            finally
            {
                UnlockData();
            }
        }

        private static void LockData()
        { 
            //todo realize it
        }

        private static void GetCurrentMaxNumber()
        {
            _maxAccountIntNumber = new MaxNumberGetter().Get();
        }

        private static void CreateNewNumber()
        {
            _maxAccountIntNumber++;
        }

        private static void UpdateAccount(Guid accountId)
        { 
            string number = new AccountNumberFormatter().GetFromInt(_maxAccountIntNumber);
            new AccountUpdater(accountId, _maxAccountIntNumber, number).Update();
        }

        private static void UnlockData()
        { 
            //todo realize it
        }

    }
}
