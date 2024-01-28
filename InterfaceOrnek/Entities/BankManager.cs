namespace InterfaceOrnek.Entities
{
    public class BankManager
    {
        IBankManager _IBankManager; //böyle çalışıyomu 
        public BankManager(IBankManager iBankManager)
        {
            _IBankManager = iBankManager;
        }

        public string Add()
        {
           return _IBankManager.AddBankProcess();
        }

        public string Delete()
        {
            return _IBankManager.DeleteBankProcess();
        }
        public string Update()
        {
            return _IBankManager.UpdateBankProces();
        }
    }
}
