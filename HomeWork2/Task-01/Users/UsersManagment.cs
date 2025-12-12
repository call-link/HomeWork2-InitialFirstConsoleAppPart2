namespace Task_01.Users;

public class UsersManager
{
    private List<User> users = new List<User>();

    public void RegisterUser()
    {
        Utilities.printTextAndSetCustomColor("Register New User, Please Enter User Details:");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        int password = int.Parse(Console.ReadLine());
        Console.Write("Card Number: ");
        long card = long.Parse(Console.ReadLine());
        Console.Write("Initial Balance: ");
        double balance = double.Parse(Console.ReadLine());

        User newUser = new User()
        {
            Username = username,
            Password = password,
            CardNumber = card,
            Balance = balance
        };

        users.Add(newUser);
        Utilities.printAndReadKyeClear($"User {username} Registered Successfully!");
    }

    public void ShowUsers()
    {
        Console.WriteLine("[ Lists of Registered Users ] \n");
        int counter = 1;
        foreach (var user in users)
        {
            Console.WriteLine($"[{counter++}] -  Username : {user.Username} | Password : {user.Password} | Card Number : {user.CardNumber} | Balance : {user.Balance}");
        }
        Utilities.printAndReadKyeClear("End of User List.");
    }


    public User? FindUser(string username, string password)
    {
        foreach (var user in users)
        {
            if (user.Username == username && user.Password.ToString() == password)
            {
                return user;
            }
        }
        return null;
    }

}
