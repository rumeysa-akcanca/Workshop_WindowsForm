using System.Runtime.CompilerServices;

namespace BankProject.Entities
{
    public class GiftCardAccount : BankAccount, IMonthEndPerform
    {
        private decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string owner, decimal initialBalance, decimal monthlyDeposit =0) : base(owner, initialBalance)
        {
            _monthlyDeposit = monthlyDeposit;
        }

        public void PerformMonthEndTransaction()
        {
            if(_monthlyDeposit!=0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Aylık ekstra yatırma yapıldı");
            }
        }
    }
}
