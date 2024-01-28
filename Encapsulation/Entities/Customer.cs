
namespace Encapsulation.Entities
{
    public class Customer
    {
        public string CID { get; set; }

        private string _nameSurname;
        public string  NameSurname { get { return _nameSurname; } 
            
            set {
                if (!string.IsNullOrEmpty(value))
                {
                  _nameSurname = value; } }
                }
        public string  Address { get; set; }
        public string Country  { get; set; }

        public Customer() 
        {
            //default olarak var , nesne oluştururken çalışır
            CID = Guid.NewGuid().ToString();
        }

        public Customer( string cid , string nameSurname)
        {
            CID = cid;
            NameSurname = nameSurname;
            
        }
    }
}
