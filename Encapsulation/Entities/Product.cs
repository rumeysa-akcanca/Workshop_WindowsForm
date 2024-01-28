using System.ComponentModel.DataAnnotations;

namespace Encapsulation.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        private int _StockQuantity;
        public int StockQuantity
        {
            get { return _StockQuantity; }
            set
            {
                if (value >= 0 && value <= 50) 
                    _StockQuantity = 100;
                else 
                 {
                    _StockQuantity = value;
                }
            }
        }

        public string ShowInfoOfProduct()
        {
            return $" Oluşturulan ürün : {ProductName} Stok miktarı : {StockQuantity}";
        }


    }
}
