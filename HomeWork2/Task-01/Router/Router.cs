using Task_01.Users;

namespace Task_01;

class RouterOptions
{
    private int optionNumber;
    private Wallet wallet;
    private UsersManager usersManager;

    public RouterOptions(UsersManager manager)
    {
        wallet = new();
        usersManager = manager; // از همان instance مشترک استفاده می‌کند
    }

    // this method for show option list and run a options - send to switch case for run
    public void showAndSelectOptions()
    {
        while (optionNumber != 10)
        {
            Console.WriteLine("Please select an option: \n");
            Console.WriteLine("[1] - Show Cash");
            Console.WriteLine("[2] - Deposit");
            Console.WriteLine("[3] - Withdraw");
            Console.WriteLine("[4] - Register User");
            Console.WriteLine("[5] - Show Users");
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
                usersManager.RegisterUser();
                break;

            case 5:
                usersManager.ShowUsers();
                break;
            case 9:
                // log out
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

