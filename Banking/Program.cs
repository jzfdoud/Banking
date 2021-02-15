using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account()
            {
                AccountNumber = "00001",
                RoutingNumber = "12356789",
                Description = "Craft Fund",
            };

            Console.WriteLine($" The {account1.Description} account has a ${account1.Balance} balance");
            account1.Deposit(750000);
            Console.WriteLine($" The {account1.Description} account has a ${account1.Balance} balance");
            account1.Withdrawl(5000);
            Console.WriteLine($" The {account1.Description} account has a ${account1.Balance} balance");

        }
    }
}
