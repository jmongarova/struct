using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте статический класс с методом void Print (string stroka, int color), который выводит на экран
строку заданным цветом. Используя перечисление, создайте набор цветов, доступных пользователю. Ввод
строки и выбор цвета предоставьте пользователю.*/
enum Color 
{
    COLOR_YELLOW, // присваивается 0
    COLOR_WHITE, // присваивается 1
    COLOR_ORANGE, // присваивается 2
    COLOR_GREEN, // присваивается 3
    COLOR_RED, // присваивается 4
    COLOR_GRAY, // присваивается 5
    COLOR_PURPLE, // присваивается 6
    COLOR_BROWN // присваивается 7
};
namespace Test4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string, please");
            string s= Console.ReadLine();
            Console.WriteLine("Enter your color \n COLOR_YELLOW 0\n COLOR_WHITE 1\n COLOR_ORANGE 2\n COLOR_GREEN 3\n COLOR_RED 4\n COLOR_GRAY 5\n COLOR_PURPLE 6\n COLOR_BROWN 7\n ");
            int c = Convert.ToInt32(Console.ReadLine());
            Class1.Print(s,c);
            Console.ReadKey();
        }
    }
}
