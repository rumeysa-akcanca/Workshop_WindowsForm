namespace AbstractOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public abstract string GetInfoOfProoduct();
            public string GetInfoCargo()
            {
                return "Kargo gönderildi";
            }
        }

        public class TecnologicProduct : Product
        {
            public override string GetInfoOfProoduct()
            {
                return $"{Name} - {Price}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}