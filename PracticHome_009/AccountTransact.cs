namespace PracticHome_009
{
    public class AccountTransact : AccountInfo, ITransaction
    {
       
        public void CreatAccount() 
        {
            Console.WriteLine("-----Enter Info Account-------  ");// ato opisanie Enum!
            Console.Write("Enter Account ID: ");
            AccountId = int.Parse(Console.ReadLine());
            Console.Write("Enter Name Account: ");
            AccountName = Console.ReadLine();
            Console.Write("Enter type Account [Commercial account/Personal account C/P: ");
            AccountType = char.Parse(Console.ReadLine());
            Console.Write("Enter Deposit: ");
            Deposit = decimal.Parse(Console.ReadLine());
        }

        public void MoidifyAccount(int accountId)
        {
            if (accountId == AccountId)
            {
                Console.Write("-----Update Account-------  ");
                Console.WriteLine($"Current account ID {AccountId} ");
                Console.WriteLine("Update Name account ID: ");
                AccountName = Console.ReadLine();
                Console.Write("Update type Account [Commercial account/Personal account C/P: ");
                AccountType = char.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Wrrong ID account! ");
            }
        }

        public void MoneyDeposit()
        {
            decimal amount;
            Console.WriteLine("Enter how much money you want to deposit: ");
            amount = decimal.Parse(Console.ReadLine());
            if (Deposit > 0)
            {
                Deposit += amount;
            }
            else
            {
                Console.WriteLine("Enter positive sum! ");
            }
        }

        public void MoneyWithdraw()
        {
            decimal amount;
            Console.WriteLine("Enter how much money you want to withdraw from your Deposit: ");
            amount = decimal.Parse(Console.ReadLine());
            if (Deposit > 0)
            {
                Deposit -= amount;
            }
            else
            {
                Console.WriteLine("You dont have money on your deposit Account! ");
            }  
        }

        public void ShowAccount()
        {
            Console.WriteLine("-----Info Account-------  ");
            Console.WriteLine($"Account ID: {AccountId} ");
            Console.WriteLine($"Name Account: {AccountName} ");
            Console.WriteLine($"Type Account: {AccountType} ");
            Console.WriteLine($"Balance Account: {Deposit} ");
            Console.WriteLine($"Time creat your Account is: {OpeneDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine("-------------------------------  ");
        }
        
        public void AccountReport()
        {
            Console.WriteLine("-----Info Account-------  ");
            Console.WriteLine($"Account ID: {AccountId} ");
            Console.WriteLine($"Balance Account: {Deposit} ");
        }
    }
}
