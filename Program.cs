using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._3
{
    class Program
    {
        class Zoostore
        {
            public string animal;
            public string sex;
            public string name;
            internal int price;
            internal int quantity;
        }
        static void Main(string[] args)
        {
            Zoostore zoostore = new Zoostore();
            Console.WriteLine("Введите название животного");
            zoostore.animal = Console.ReadLine();
            Console.WriteLine("Пол ");
            zoostore.sex = Console.ReadLine();
            Console.WriteLine("Имя ");
            zoostore.name = Console.ReadLine();
            Console.WriteLine("Цену");
            zoostore.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество");
            zoostore.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(zoostore.animal);
            Console.WriteLine(zoostore.sex);
            Console.WriteLine(zoostore.name);
            Console.WriteLine(zoostore.price);
            Console.WriteLine(zoostore.quantity);
            Console.ReadKey();
        }
    }
}
