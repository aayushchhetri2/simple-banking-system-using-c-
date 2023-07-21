using System;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Simple Banking System!");

        // Create a new account
        Console.Write("Enter your account number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter your name: ");
        string accountHolderName = Console.ReadLine();

        Account account = new Account(accountNumber, accountHolderName);

        // Perform transactions
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter the amount to deposit: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case 2:
                    Console.Write("Enter the amount to withdraw: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;

                case 3:
                    account.DisplayBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using Simple Banking System. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
