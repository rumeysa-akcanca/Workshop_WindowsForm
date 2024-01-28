

namespace InterfaceOrnek.Entities
{
    public class ZiraatBank : Bank, IBankManager
    {
        public string AddBankProcess()
        {
            return("Ziraat kartınıza yeni bir hesap ekledi");
        }

        public string DeleteBankProcess()
        {
            return("Ziraat hesap kaydınız  silindi");
        }

        public string UpdateBankProces()
        {
            return("Ziraat hesabınız günzellendi");
        }
    }
}
