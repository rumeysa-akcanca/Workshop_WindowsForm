

namespace InterfaceOrnek.Entities
{
    public class GarantiBank : Bank, IBankManager
    {
        public string AddBankProcess()
        {
            return("Garanti kartınıza yeni bir hesap ekledi");
        }

        public string DeleteBankProcess()
        {
            return("Garanti hesap kaydınız  silindi");
        }

        public string UpdateBankProces()
        {
            return("Garanti hesabınız günzellendi");
        }
    }
}
