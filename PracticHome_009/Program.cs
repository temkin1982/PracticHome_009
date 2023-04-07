namespace PracticHome_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Объявляем массив
            //int[] myArr = new int[5];

            //// Инициализируем каждый элемент массива вручную
            //myArr[0] = 100;
            //myArr[1] = 23;
            //myArr[2] = 25;
            //myArr[3] = 31;
            //myArr[4] = 1;

            //foreach (int i in myArr)
            //    Console.WriteLine(i);

            //Console.ReadLine();
            //Console.WriteLine("----------------------------");

            //int opt;
            //var intro = new IntroStruct();
            //var transaction = new AccountTransact();

            //intro.Intro();
            //intro.Loading();
            //Console.Clear();

            //do
            //{
            //    Console.Write("\n\n\tMain Menu");
            //    Console.Write("\n 1.Creat a new Account:");
            //    Console.Write("\n 2.Info about Account");
            //    Console.Write("\n 3.Update Info about your Account");
            //    Console.Write("\n 4.Enter amount for your deposit");
            //    Console.Write("\n 5.Withdraw amount for your deposit");
            //    Console.Write("\n 6.Account report");
            //    Console.Write("\n 7.Exit from App");
            //    Console.Write("\n Choose from 1-7: ");
            //    opt = int.Parse(Console.ReadLine());
            //    Console.Clear();
            //    switch (opt)
            //    {
            //        case (int)Options.New:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                transaction.CreatAccount();  
            //                break;
            //            }
            //        case (int)Options.Show:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                transaction.ShowAccount(); 
            //                break;
            //            }
            //        case (int)Options.Deposit:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                transaction.MoneyDeposit();
            //                break;
            //            }
            //        case (int)Options.Withdraw:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                transaction.MoneyWithdraw();
            //                break;
            //            }
            //        case (int)Options.BalanceShow:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                transaction.AccountReport();
            //                break;
            //            }
            //        case (int)Options.Modify:
            //            {
            //                Console.Clear();
            //                intro.Loading();
            //                Console.Clear();
            //                Console.Write("Enter ID account: ");
            //                int id = int.Parse(Console.ReadLine());  
            //                transaction.MoidifyAccount(id);
            //                break;
            //            }

            //        case (int)Options.Exit:
            //            {
            //                Environment.Exit(0);
            //                break;
            //            }
            //    }
            //} while (opt !=(int)Options.Exit);

            var b = new B();
            var c = new C();
            Console.WriteLine(b.Sum(2,3));
            Console.WriteLine(c.Sum(2, 3));

        }
    }class A
    {
        public virtual int Sum(int a, int b)
        {
            return a + b;
        }
    }
    class B : A
    {

    }
    class C : A
    {
        public override int Sum(int a, int b)
        {
            return a + b + 1 ;
        }
    }
}