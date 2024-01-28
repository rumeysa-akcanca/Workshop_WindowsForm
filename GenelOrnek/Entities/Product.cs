namespace GenelOrnek.Entities
{
    public class Product //base class
    {
        public string ProductID { get; set; } = Guid.NewGuid().ToString(); //her bir product nesnesi aldığımazda id si dolu gelicek 
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public double  UnitPrice { get; set; }
        public string Note { get; set; }

        public virtual  double CalculateKDV() //sanal
        {
            return UnitPrice * 1.18; //polymorfizm
        }
    }
}
