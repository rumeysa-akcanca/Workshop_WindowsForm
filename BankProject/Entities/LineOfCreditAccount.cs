
namespace BankProject.Entities
{
    //kredi kartı
    public class LineOfCreditAccount : BankAccount, IMonthEndPerform
    {
        public LineOfCreditAccount(string owner, decimal initialBalance) : base(owner, initialBalance)
        {
        }

        public void PerformMonthEndTransaction()
        {
            if(Balance < 0)
            {
                decimal interest = Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Hrsaptan aylık faiz gideri alındı.");
            }
            //3 sınıf için çalıştırmak gerekicek?
        }
    }
}
