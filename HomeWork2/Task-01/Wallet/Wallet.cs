namespace Task_01;

class Wallet
{
    public double balance;
    public double Balance => balance;

    // deposit is a method for add mony in youre wallet
    public void Deposit()
    {
        int amount;
        Console.Write("Enter the amount to deposit: \n");
        amount = int.Parse(Console.ReadLine());
        if (amount == 0)
        {
            Utilities.printAndReadKyeClear("the amount equal zero !");
            return;
        }
        balance += amount;
        Utilities.printAndReadKyeClear($"the amount +{amount}$ deposited successfully .");
    }

    // Withdraw is a method for mines youre balanse
    public void Withdraw()
    {
        int amount;
        // Console.Write("Enter the amount to withdraw: \n");
        Utilities.printTextAndSetCustomColor("Enter the amount to withdraw:");

        amount = int.Parse(Console.ReadLine());
        if (amount == 0)
        {
            Console.WriteLine("the amount equal zero !");
            return;
        }
        if (amount > balance)
        {
            Utilities.printAndReadKyeClear("the amount bigger balance !");
        }
        else
        {
            balance -= amount;
            Utilities.printAndReadKyeClear($"the amount -{amount}$ withdrawed successfully !");
        }
    }

    // show balance is a method for show all mony in youre wallet
    public void ShowBalance()
    {
        Utilities.printAndReadKyeClear($"The balance is : {balance}$");
    }
}

