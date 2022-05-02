static void Main(string[] args)
{

}

public class Account
{
    private double _balance;
    public double balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public double Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new ArgumentException("Error: insufficient funds for withdrawal.");
        } else if (amount <= 0 || amount == null)
        {
            throw new ArgumentException("Withdrawals must be greater than $0");
        }

        balance = balance - amount;
        return balance;
    }

    public double Deposit(double amount)
    {
        if(amount <= 0 || amount == null)
        {
            throw new ArgumentException("Deposits must be in amounts greater than $0");
        }

        balance += amount;
        return balance;
    }
}