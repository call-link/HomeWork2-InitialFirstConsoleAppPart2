namespace Task_01;


class RouterOptions
{
    private int optionNumber;
    private Wallet wallet;

    public RouterOptions()
    {
        wallet = new Wallet();
    }

    // this method for show option list and run a options - send to switch case for run
    public void runPayAndDeps()
    {
        while (optionNumber != 10)
        {
            Console.WriteLine("Please select an option: \n");
            Console.WriteLine("[1] - Show Cash");
            Console.WriteLine("[2] - Deposit");
            Console.WriteLine("[3] - Withdraw");
            Console.WriteLine("[4] - Transfer");
            Console.WriteLine("[10] - Exit");
            optionNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            // run method options
            WalletManageSwitch();
        }
    }

    // run all options - methods manager wallet
    public void WalletManageSwitch()
    {
        switch (optionNumber)
        {
            case 1:
                // show cash
                wallet.ShowBalance();
                break;
            case 2:
                // deposit
                wallet.Deposit();
                break;
            case 3:
                // withdraw
                wallet.Withdraw();
                break;
            case 4:
                // transfer other wallet
                // در کلاس wallet یک متد جدید بساز:
                // public void Transfer(double amount, wallet targetWallet)
                break;
            case 8:
                // reset bulunce
                break;
            case 10:
                Utilities.printAndReadKyeClear($"Youre Wellcome ...");
                break;


            default:
                // invalid option
                Console.WriteLine("Invalid Options, Try again!");
                break;
        }
    }
}

