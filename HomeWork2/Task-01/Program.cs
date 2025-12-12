using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using Task_01.Users;
namespace Task_01;

class Program
{
    static void Main()
    {
        UsersManager usersManager = new UsersManager();

        Auth auth = new Auth(usersManager);

        auth.LoginOrRegistration();

        // after login for work with my wallet
        if (auth.isLogin == true)
        {
            RouterOptions routerOptions = new RouterOptions(usersManager);
            routerOptions.showAndSelectOptions();
        }
    }

}




















// task 01
// class Student
// {
//     private string name;
//     private int age;

//     public string Name { get; set; }
//     public int Age { get; set; }

//     public void Introduce()
//     {
//         Console.WriteLine($"Hello, muname is : {name} , my age is : {age}");
//     }

//     public Student(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }
// }
// static void Main()
// {
//     Student student = new Student("Ali", 12);
//     student.Introduce();
// }