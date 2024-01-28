using System.CodeDom;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankProject.Entities
{
    public class BankAccount
    {
        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            // Balance = initialbalance; //ilk açılışta da bir para yatırma işlemi olması lazım
            MakeDeposit(initialBalance, DateTime.Now, "İlk para yatırma işlemi gerçekleşti.");
        }

        public string AccountNumber { get; set; } = Guid.NewGuid().ToString(); // ne olduğuna bak, ToString'e gerek yok

        public string Owner { get; set; }

        public decimal Balance
        {
            //Encapsulation : kapsülleme , koruma 
            get //sadece okuma
            {
                decimal result = 0;
                foreach (var item in allTransactions)
                {
                    result += item.Amount;
                }
                return result;
            }
           // set { Balance = value; }
        } //hesapta kalan para 


        //bütün yatırma ve çekme işlemleri burada yeni bir transaction olarak tutulacaktır
        private List<Transaction> allTransactions = new List<Transaction>(); //generic list

        public void MakeDeposit(decimal amount, DateTime date, string Note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Yatırılan tutar pozitif olmalıdır");
            }
            //para yatırma işlemi yapalım

           var deposit =  new Transaction(amount, date, Note);
           allTransactions.Add(deposit);
        }

        //para çekme işlemi yapılıyo
        public void MakeWithDrawal(decimal amount, DateTime date, string Note)
        {
            //para çekilirken pozitif değer çekmeli
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Çekilen tutar pozitif olmalıdır");
            }
            //bakiye yeterli mi 
            if(Balance-amount<0)
            {
                throw new InvalidOperationException("Hesapta yeterli bakiye bulunmamaktadır");
            }
            //para çekme işlemi 
            var withdrawal = new Transaction(-amount, date, Note);
            allTransactions.Add(withdrawal);

        }

        //turner if

        public string GetAccountHistory()
        {
            //Hesap açıldığındada herhangi bir transaction yapıldığında da bütün transactionları alıp dökecek 

            var report =  new StringBuilder();
            int sayac =1;
            foreach (var item in allTransactions)
            {
                //turner
                 string typeOfProcess = (item.Amount < 0 ) ? "Para Çekme İşlemi" :  "Para Yatırma  İşlemi" ;
                 report.AppendLine($"{sayac}.işlem : {item.Amount} $ {typeOfProcess}");
                 sayac++;
            }
            return report.ToString();
        }
    }
}
