using GenelOrnek.Entities;
using System.Diagnostics;

namespace GenelOrnek
{
    public partial class Form1 : Form
    {
        int selectedproduct;
        Basket basket = new Basket();
        Product p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts(); //ctrl and noktaya bas
        }

        private void GetProducts()
        {
            cmbUrun.Items.AddRange(new string[] { "Telefon", "Gömlek" });
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //comboboxtan hangi ürünü seçtiğimizi bulmalıyız
            //selectedIndexChanged eventi
            if (selectedproduct == 0)
            {
                p = new Phone()
                {
                    ProductName = txtUrunAdi.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    UnitPrice = 1000,
                    TimeOfBatttary = 64
                };
            }
            else if (selectedproduct == 1)
            {

                p = new Shirt()
                {
                   ProductName = txtUrunAdi.Text,
                   Quantity = Convert.ToInt32(nmrAdet.Value),
                   UnitPrice = 500,
                   Size = "M",
                   TypeOfMaterial = "Naylon"
                };
            }
            //else
            //{
            //    MessageBox.Show("Lütfen bir ürün seçiniz");
            //}

            basket.AddProduct(p);

            UpdateList();

            lblBasketTotal.Text = basket.TotalBasket().ToString();
        }

        private void UpdateList()
        {
            lstliste.Items.Clear();
            foreach (var item in basket.GetAllProducts())
            {
                lstliste.Items.Add($"{item.ProductName}-{item.Quantity}");
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            //değişkenin ömrü tanımlandığı yere kadar
             selectedproduct = cmbUrun.SelectedIndex;
        }
    }
}