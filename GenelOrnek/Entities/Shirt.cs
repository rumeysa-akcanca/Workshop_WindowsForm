namespace GenelOrnek.Entities
{
    public class Shirt : Product
    {
        public string Size { get; set; }
        public string TypeOfMaterial { get; set; } //kumaş türü
        
        public  override  double CalculateKDV()
        {
            return UnitPrice * 1.08; //yüzde 8 dön
        }

        //public override string ToString()
        //{
        //    return $"{ProductName} - {Quantity}";
        //}

    }
}
