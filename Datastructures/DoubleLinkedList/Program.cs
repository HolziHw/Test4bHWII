using System;

namespace DoubleLinkedList.model
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<Car> dll = new DoubleLinkedList<Car>();
            Car c1 = new Car("Mercedes", "C-Klasse", 340);
            Car c2 = new Car("McLaren", "Senna", 1000);
            Car c3 = new Car("Audi", "A1", 100);
            Car c4 = new Car("Koenigsegg", "Agera", 1298);

            dll.Add(c1);
            dll.Add(c2);
            dll.Add(c3);
            Console.WriteLine(dll);

            bool isStartItem;
            /*
            dll.Change(c1, new Car("newMercedes", "newC-Klasse", 400));
            */
            dll.AddItemAfterItem(c4, c2);
            Console.WriteLine(dll);
            dll.Remove(c4);
            dll.Remove(c2);

            Console.WriteLine(dll);
        }
    }
}
