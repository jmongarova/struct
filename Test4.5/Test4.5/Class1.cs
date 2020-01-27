using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._5
{
    static class Class1
    {
        

        static public void Print(string stroka, int color)
        {
            Color c;
            switch (color)
            {
                case 0:
                    c = Color.COLOR_YELLOW;
                    Console.WriteLine($"Print your string {stroka} color {c} ");
                    break;
                case 1:
                    c = Color.COLOR_WHITE;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 2:
                    c = Color.COLOR_ORANGE;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 3:
                    c = Color.COLOR_GREEN;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 4:
                    c = Color.COLOR_RED;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 5:
                    c = Color.COLOR_GRAY;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 6:
                    c = Color.COLOR_PURPLE;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
                case 7:
                    c = Color.COLOR_BROWN;
                    Console.WriteLine($"Print your string {stroka} color {c}");
                    break;
            }
        }
    }
}
