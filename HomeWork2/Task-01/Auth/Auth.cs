namespace Task_01;

class Auth
{

    // وریفای کردن و گرفتن مقادیر از کاربر باید جدا از هم باشن بنطرم
    private string username;
    private string password;
    public bool isLogin = false;
    public int tryCount = 3;

    public string Username => username;
    public string Password => password;

    public bool checkIsLogin()
    {
        while (tryCount > 0)
        {
            Console.Clear();
            username = GetUsername();
            password = GetPassword();

            if (username == "admin" && password == "admin")
            {
                isLogin = true;
                Utilities.printTextAndSetCustomColor($"Hi {username} dear, Welcome to Wallet Manager.");
                return true;
            }
            else
            {
                tryCount--;
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
