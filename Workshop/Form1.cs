using Workshop.Entities;

namespace Workshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.", "blaba");
            btnKaydet.Text = "Güncelle";//set işlemi sayesinde propertye, değeri sağdan sola atadık
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Account account = new Account(); //bir sınıfın örneğini alma
            account.AccountNumber = Guid.NewGuid().ToString();
            account.Owner = "Mehmet";
            account.Balance = 1000; //double integer'dan daha büyük

            LstList.Items.Add($"Hesap bilgisi : {account.Owner} / { account.Balance}" );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}