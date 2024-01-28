namespace BankProject.Entities
{
    public class Transaction
    {
        //hesabı açarken para yatırmalıyız
        public Transaction(decimal amount,DateTime date,string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        //her bir işlem önemli , para çekme i para yatırma 

    }
}
