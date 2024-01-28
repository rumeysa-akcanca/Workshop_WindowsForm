namespace GenelOrnek.Entities
{
    public class Basket
    {
        private List<Product> ProductList = new List<Product>(); //asıl sepet

        public void AddProduct(Product product)
        {
            //varsa adedi güncelle yoksa  listeye ekle //Linq ve lamda expression
            var result = ProductList.FirstOrDefault(x => x.ProductName == product.ProductName);
            if (result != null)
            {
                result.Quantity += product.Quantity;
            }
            else
            {
              ProductList.Add(product);
                
            }
        }

        public List<Product> GetAllProducts()
        {
            return ProductList;
        }

        public double TotalBasket()
        {
            double total=0;
            foreach (var item in ProductList)
            {
                //total += item.UnitPrice * item.Quantity;
                total += item.CalculateKDV() * item.Quantity;
            }
            return total;
        }
    }
}
