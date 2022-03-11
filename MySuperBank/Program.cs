using System;
using System.Collections.Generic;


namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("siri", 1000);
            //Console.WriteLine($"This is bank acount of serial number {account.number} is created for {account.Owner} having {account.Balance} Blance");

            account.MakeWithdrawl(120,DateTime.Now,"charity");
           // Console.WriteLine(account.Balance);

            account.MakeWithdrawl(50, DateTime.Now, "Xbox");
            //Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHIstory());









            /*//comments
            //Test for negaive balance
            try
            {
                account.MakeWithdrawl(99999, DateTime.Now, "attemp to overdraw");
            }
            catch (InvalidOperationException e)
            {
                 Console.WriteLine("Exception caught trying to overdraw");
                 Console.WriteLine(e.ToString());
            }

            //TESTING initial balance
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }*/

           

            
            
        }
    }
}
