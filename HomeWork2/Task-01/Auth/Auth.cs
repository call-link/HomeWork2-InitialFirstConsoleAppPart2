using Task_01.Users;

namespace Task_01;

class Auth
{
    private UsersManager usersManager;
    public bool isLogin = false;
    public int tryCount = 3;
    public Auth(UsersManager manager)
    {
        usersManager = manager;
    }
    // Users.UsersManager usersManager = new Users.UsersManager();
    public bool LoginOrRegistration()
    {
        Utilities.printTextAndSetCustomColor("[ Login | Register Page ]");
        Console.WriteLine("[1]- Register ");
        Console.WriteLine("[2]- Login ");
        int LoginRegisterNumber = int.Parse(Console.ReadLine());
        while (tryCount > 0)
        {
            Console.Clear();

            if (LoginRegisterNumber == 1)
            {
                // register page
                usersManager.RegisterUser();
                isLogin = false;
                LoginRegisterNumber = 2;
                continue;

            }
            else if (LoginRegisterNumber == 2)
            {
                // login page
                Utilities.printTextAndSetCustomColor("Login Page \n");
                string username = GetUsername();
                string password = GetPassword();

                var findUser = usersManager.FindUser(username, password);
                if (findUser != null)
                {
                    isLogin = true;
                    Utilities.printTextAndSetCustomColor($"Hi {username} dear, Welcome to Wallet Manager.");
                    return true;
                }
                else
                {
                    Utilities.printAndReadKyeClear("Username or Password is incorrect !");
                    tryCount--;
                    continue;
                }


            }

        }
        isLogin = false;
        return false;

    }


    private string GetUsername()
    {
        // Console.Clear();
        Utilities.printTextAndSetCustomColor($"Login Page , Try : {tryCount}");
        Console.Write("Enter your username: \n");
        return Console.ReadLine();
    }
    private string GetPassword()
    {
        Console.Write("Enter your password: \n");
        return Console.ReadLine();
    }
}
