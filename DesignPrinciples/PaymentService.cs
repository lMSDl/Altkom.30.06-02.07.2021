using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Accounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int accountId, float amount)
        {
            var account = FindAccountById(accountId);
            if (account == null)
            {
                return false;
            }

            if (GetBalance(accountId) + account.AllowedDebit < amount)
            {
                return false;
            }

            account.Outcome += amount;
            return true;
        }

        private PaymentAccount FindAccountById(int accountId)
        {
            return Accounts.SingleOrDefault(x => x.Id == accountId);
        }

        public void Fund(int accountId, float amount)
        {
            var account = FindAccountById(accountId);
            if (account == null)
            {
                return;
            }

            account.Income += amount;
        }

        public float? GetBalance(int accountId)
        {
            var account = FindAccountById(accountId);
            return account?.Income - account?.Outcome;
        }
    }
}
