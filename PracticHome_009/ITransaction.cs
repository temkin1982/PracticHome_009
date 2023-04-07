namespace PracticHome_009
{
    public interface ITransaction
    {
        public void CreatAccount();  //sosdat account

        public void ShowAccount();   //pokazat account

        public void MoidifyAccount(int accountId); // obnavit accounta (shtob obnavit account dobavili int account)

        public void MoneyDeposit(); // depozit denyag

        public void MoneyWithdraw(); // vivod denyag

        public void AccountReport();// pokazat tekuchi Balance

    }
}
