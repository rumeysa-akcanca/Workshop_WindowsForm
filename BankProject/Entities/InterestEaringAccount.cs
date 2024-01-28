namespace BankProject.Entities
{
    //faiz getiren hesap
    public class InterestEaringAccount : BankAccount, IMonthEndPerform
    {
        public InterestEaringAccount(string owner, decimal initialBalance) : base(owner, initialBalance)
        {
        }

        public void PerformMonthEndTransaction()
        {
            if(Balance > 500)
            {
                decimal result = Balance * 0.05m;
                MakeDeposit(result,DateTime.Now," Ayık faiz getirisi hesaba yatırıldı.");
            }
        }
    }
}
