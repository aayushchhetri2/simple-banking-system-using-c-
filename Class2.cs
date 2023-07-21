public class Account
{
    public int AccountNumber { get; private set; }
    public string AccountHolderName { get; private set; }
    public decimal Balance { get; private set; }

    public Account(int accountNumber, string accountHolderName)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}
