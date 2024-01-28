using BankProject.Entities;
using System.Data;

namespace BankProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAySonu.Visible = false;
            txtAySonu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Acıklama
            /*
             BankAcount
             Banka hesap numarası otomatik olarak  oluşturulmalıdır.
             Hesap sahibinin ismi girilmelidir.
             İlk açılışta bakiye girilmesi gerekir.
             Banka hesabı hesap sahibinin adı ve ilk bakiye girişi yapılarak oluşturulmalıdır

            Para çekilebilsin. 
            Hesapta para yoksa para çekilemezin.eksilere inemez

             Para yaırılabilsin.
             Para yatırıken de 0 dan farklı , pozitif  bir değer yatırılmalı.

            InterestEarningAccount (Faiz Getiri Hesabı)
            Eğer mevcut bakiye 500 dolardan fazla ise her ay sonu  %5 faiz getirisi sağlar

            LineOfCreditAccount (Kredi Limit Hesabı)
            Eksi bakiyeye düşebilir .Ancak - bakiye söz konusu ise ay sonu  %7 faiz gideri uygulanır.

            GiftCardAccount (Hediye Kartı Hesabı)
            Her ay sonu istenirse bir miktar para yatırma işlemi yapılabilir.

             */
            #endregion

            //hesap türü ve işlem tipini doldur
            FillComboBox();
        }
           private void FillComboBox()
            {
                cmbIslemtipi.Items.AddRange(Enum.GetNames(typeof(TypeOfProcess)));
                cmbHasapTuru.Items.AddRange(Enum.GetNames(typeof(TypeOfAccount)));
            }
        BankAccount account;

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            try
            {
                string owner = txtAdSoyad.Text;
                decimal balance = Convert.ToDecimal(txtBakiye.Text);
                int chooseaccount = cmbHasapTuru.SelectedIndex;
                if (cmbHasapTuru.SelectedIndex == 0) 
                {
                    account = new InterestEaringAccount(owner, balance);
                }
                else if (cmbHasapTuru.SelectedIndex == 1)
                {
                    account = new LineOfCreditAccount(owner, balance);
                }
                else
                {
                    decimal endBalance = Convert.ToDecimal(txtAySonu.Text);
                    account = new GiftCardAccount(owner, balance, endBalance);
                    //giftcart seçildiğinde çıksın
                }

                txtId.Text = account.AccountNumber;
                lblAccountStatus.Text = "Hesabınız başarıyla oluşturuldu.";

                // lstListe.Text = account.GetHistoryTransaction();
                UpdateBalance();

            }
            catch (Exception ex)
            {

                lblAccountStatus.Text = ex.Message;
            }
        }

        private void UpdateBalance()
        {
            if(account != null)
            {
                lblAccountFiles.Text = account.GetAccountHistory();//sorun burda
                lblTotalBalance.Text = account.Balance.ToString();
            }
        }
        private void cmbHasapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
          // bool result = (cmbHasapTuru.SelectedIndex == -1 || cmbHasapTuru.SelectedIndex != 2) ? false : true;
            bool result = (cmbHasapTuru.SelectedIndex == 2 )? true : false;
            txtAySonu.Visible = result;
            lblAySonu.Visible = result;
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(Convert.ToDecimal(txtTutar.Text), DateTime.Now, txtNot.Text);
            string processType;

            if (cmbIslemtipi.SelectedIndex == 0)
            {
                account.MakeWithDrawal(Convert.ToDecimal(txtTutar.Text), DateTime.Now, txtNot.Text);
            }
            else 
            {
                account.MakeDeposit(Convert.ToDecimal(txtTutar.Text), DateTime.Now, txtNot.Text);
            }
            UpdateBalance();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}