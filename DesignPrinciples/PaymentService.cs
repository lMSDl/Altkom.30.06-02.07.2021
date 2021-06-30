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

        public bool DeleteAccount(PaymentAccount account)
        {
            return Accounts.Remove(account);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return Accounts.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int accountId, float amount)
        {
            var account = Accounts.SingleOrDefault(x => x.Id == accountId);
            if (account == null)
            {
                return false;
            }

            if (account.Income - account.Outcome + account.AllowedDebit < amount)
            {
                return false;
            }

            account.Outcome += amount;
            return true;
        }

        public void Fund(int accountId, float amount)
        {
            var account = Accounts.Where(x => x.Id == accountId).SingleOrDefault();
            if (account == null)
            {
                return;
            }

            account.Income += amount;
        }

        public float? GetBalance(int accountId)
        {
            var account = Accounts.Where(x => x.Id == accountId).SingleOrDefault();
            return account?.Income - account?.Outcome;
        }
    }
}
