using Encapsulation.Entities;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            lblMesaj.AutoSize = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();
           // lblcustomer.Text = $"{customer.CID} : {customer.NameSurname}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductName = " HP Laptop",
                StockQuantity = 140,
                Price = 544.54,
                ProductID = 1
            };
            lblMesaj.Text = product.ShowInfoOfProduct();
        }
    }
}