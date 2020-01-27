using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._2
{
    struct Train
    { /*название пункта назначения,
номер поезда, время отправления.
Написать программу, выполняющую следующие действия:
- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
упорядочены по номерам поездов);
- вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести*/

        public string destination;
        public int number_train;
        public string departure_time;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains;
            trains=new Train[8];
            string temp_destination;
            int temp_number_train;
            string temp_departure_time;
            Console.WriteLine("Enter element struct");
            Console.WriteLine("Destination->");
            trains[0].destination = Console.ReadLine();
            Console.WriteLine("Number_train->");
            trains[0].number_train = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Departure_time->");
            trains[0].departure_time = Console.ReadLine();
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Destination->");
                trains[i].destination= Console.ReadLine();
                Console.WriteLine("Number_train->");
                trains[i].number_train = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Departure_time->");
                trains[i].departure_time = Console.ReadLine();
                if (trains[i-1].number_train < trains[i].number_train)
                {
                    temp_destination = trains[i - 1].destination;
                    temp_number_train = trains[i - 1].number_train;
                    temp_departure_time = trains[i - 1].departure_time;
                    trains[i - 1].destination = trains[i].destination;
                    trains[i - 1].number_train = trains[i].number_train;
                    trains[i - 1].departure_time = trains[i].departure_time;
                    trains[i].destination = temp_destination;
                    trains[i].number_train= temp_number_train;
                    trains[i].departure_time= temp_departure_time;
                }
            }
            Console.WriteLine("Enter your train");
            bool flag=false;
            int n= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                if (trains[i].number_train == n)
                {
                    Console.WriteLine($"Destination: {trains[i].destination}  Number_train: {trains[i].number_train} Departure_time {trains[i].departure_time}");
                    flag = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Found train");
            }
            else
            {
                Console.WriteLine("Not found train");
            }
            Console.ReadKey();
        }
    }
}
