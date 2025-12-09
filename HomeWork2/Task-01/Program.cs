using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
namespace Task_01;

class Program
{
    static void Main()
    {
        // check name and pass for opened menu page
        Auth auth = new Auth();
        auth.checkIsLogin();

        // after login for work with my wallet
        if (auth.isLogin == true)
        {
            RouterOptions routerOptions = new RouterOptions();
            routerOptions.runPayAndDeps();
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