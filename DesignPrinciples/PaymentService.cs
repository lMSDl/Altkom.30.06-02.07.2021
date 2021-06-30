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
            return account?.Charge(amount) ?? false;
        }

        private PaymentAccount FindAccountById(int accountId)
        {
            return Accounts.SingleOrDefault(x => x.Id == accountId);
        }

        public void Fund(int accountId, float amount)
        {
            var account = FindAccountById(accountId);
            account?.Fund(amount);
        }
    }
}
