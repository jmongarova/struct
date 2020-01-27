using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество
дней до его следующего дня рождения.*/
namespace Test4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date your birsday");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = new DateTime(year, month, num);
            Console.WriteLine(date1); 
            DateTime date2 = DateTime.Now;
            DateTime date3=date1.AddYears(1);
            Console.WriteLine(date2); 
            Console.WriteLine(date3.Subtract(date2));
            Console.ReadKey();
        }
    }
}
