namespace Task_01;

class Auth
{

    // وریفای کردن و گرفتن مقادیر از کاربر باید جدا از هم باشن بنطرم
    private string username;
    private string password;
    public bool isLogin = false;
    public int tryCount = 3;
    public int LoginRegisterNumber;

    public string Username => username;
    public string Password => password;
    Users.UsersManager usersManager = new Users.UsersManager();
    public bool LoginOrRegistration()
    {
        Utilities.printTextAndSetCustomColor("[ Login | Register Page ]");
        Console.WriteLine("[1]- Register ");
        Console.WriteLine("[2]- Login ");
        LoginRegisterNumber = int.Parse(Console.ReadLine());
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
                username = GetUsername();
                password = GetPassword();

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
