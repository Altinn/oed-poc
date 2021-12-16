namespace dan_oed_poc_razor.Models
{
    public class BankResponse
    {
        public List<BankInfo> BankAccounts { get; set; } = new();
        public double TotalBalance { get; set; } = 0;
    }

    public class BankInfo
    {
        public string BankName { get; set; } = string.Empty;
        public bool IsImplemented { get; set; } = true;
        public List<Account> Accounts { get; set; } = new();
        public double TotalBalance { get; set; } = 0;
        public Exception? Exception { get; set; } = null;
    }

    public class Account
    {
        public string AccountNumber { get; set; } = string.Empty; // Seperate property by now. Copy of AccountDetail.AccountIdentifier
        //public AccountDetail AccountDetail { get; set; } // Not mapped to internal by now
        //public ICollection<Transaction> Transactions { get; set; } // Not mapped to internal by now
        public double AccountBalance { get; set; } = 0;
    }

}
