using InterfaceOrnek.Entities;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // oop' ye c++ ya da java dan bak. 
        }

        private void btnGaranti_Click(object sender, EventArgs e)
        {
            GarantiBank garantiBank= new GarantiBank();
            garantiBank.ID = 0;
            garantiBank.SecurityCode = "102";
            BankManager bankManager = new BankManager(garantiBank);
            bankManager.Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZiraatBank ziraat = new ZiraatBank();
            ziraat.ID = 0;
            ziraat.SecurityCode = "102";
            BankManager bankManager = new BankManager(ziraat);
            bankManager.Add();
        }
    }
}