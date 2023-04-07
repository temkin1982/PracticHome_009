namespace PracticHome_009
{
    public class AccountInfo
    {
        private int accountId;
        private string accountName;
        private decimal deposit; // peremenaya katoraya budit hronit nashi dengi deposit cherez Type decimal! 
        private DateTime openeDate;
        private char accountType; // ato dla tavo shtob razdilat mejdu Comerchiskim chotam i Personalni.

        public AccountInfo()
        {
            openeDate= DateTime.Now;
        }

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }  
        
        public string AccountName
        { 
            get { return accountName; }
            set { accountName = value; }
        }

        public char AccountType
        {
            get { return accountType; }
            set { accountType = value; } 
        }

        public decimal Deposit
        {
            get { return deposit; }
            set 
            {
                 if (deposit >= 0 )
                 {
                    deposit = value;
                    
                 }
                 else
                 {
                    Console.WriteLine("Deposit is can not be under 0!!! ");
                 }

            }
        }

        public DateTime OpeneDate
        {
            get { return openeDate; }
            set { openeDate= value; }
        }
    }
}
