class BankAccount
{
    public string Owner { get; set; }
    private decimal balance;

    public BankAccount(string owner, decimal initial_balance)
    {
        Owner = owner;
        balance = initial_balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Rakib", 5000);
        BankAccount account2 = new BankAccount("Rahim", 3000);

        account1.Deposit(2000);
        account1.Withdraw(1000);

        Console.WriteLine(account1.Owner);
        Console.WriteLine(account1.GetBalance());

        Console.WriteLine(account2.Owner);
        Console.WriteLine(account2.GetBalance());
    }
}