using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за
месяц.
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать
или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена преми*/
enum Post
{
    Beginner_programmer = 100,
    Manager = 120,
    Programmer = 128,
    Director = 140
}
namespace Test4._6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Accauntant Name= new Accauntant();
            Post worker;
            bool flag;
            worker = Post.Beginner_programmer;
            Console.WriteLine("Enter hours for Beginner_programmer");
            int B_p = Convert.ToInt32(Console.ReadLine());
            flag=Name.AskForBonus(worker, B_p);
            Console.WriteLine("Beginner programmer: \"{0}\", обязан был отработать {1}", worker, (int)worker);
            Name.Prem(flag);
            worker = Post.Manager;
            Console.WriteLine("Enter hours for Manager");
            int M = Convert.ToInt32(Console.ReadLine());
            flag = Name.AskForBonus(worker, M);
            Console.WriteLine("Manager: \"{0}\", обязан был отработать {1}", worker, (int)worker);
            Name.Prem(flag);
            worker = Post.Programmer;
            Console.WriteLine("Enter hours for Programmer");
            int R = Convert.ToInt32(Console.ReadLine());
            flag=Name.AskForBonus(worker, R);
            Console.WriteLine("Programmer: \"{0}\", обязан был отработать {1}", worker, (int)worker);
            Name.Prem(flag);
            worker = Post.Director;
            Console.WriteLine("Enter hours for Director");
            int D = Convert.ToInt32(Console.ReadLine());
            flag = Name.AskForBonus(worker, D);
            Console.WriteLine("Director: \"{0}\", обязан был отработать {1}", worker, (int)worker);
            Name.Prem(flag);
            Console.ReadKey();
        }
    }
}
