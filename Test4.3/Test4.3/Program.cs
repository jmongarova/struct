using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._3
{/*В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass
значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct
значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные*/
    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.change = "не изменено";
            ClassTaker(myClass1);
            Console.WriteLine($"myClass change {myClass1.change}");

            MyStruct myStruct1 = new MyStruct();
            myStruct1.change = "не изменено";
            StruktTaker(myStruct1);
            Console.WriteLine($"myStruct change {myStruct1.change}");
            Console.ReadKey();
        }
    }

}
