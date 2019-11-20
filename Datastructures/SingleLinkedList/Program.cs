using System;
using SingleLinkedList.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasse Person testen
            /*
            Person p = new Person("Eias", "Rist", new DateTime(2000, 4, 24));
            //Console.WriteLine(p);
            Person p2 = new Person("Eias", "Rist", new DateTime(2000, 4, 24));

            Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));

            if(p == p2)
            {
                Console.WriteLine("p1 und p2 sind gleich : ==");
            }else
            {
               Console.WriteLine("p1 und p2 sind nicht gleich : ==");
            }
            if (p.Equals(p2))
            {
                Console.WriteLine("p1 und p2 sind gleich : Equals()");
            }
            else
            {

                Console.WriteLine("p1 und p2 sind nicht gleich : Equals()");
            }
            if (p3 == p2)
            {
                Console.WriteLine("p3 und p2 sind gleich  : ==");
            }
            else
            {
                Console.WriteLine("p3 und p2 sind nicht gleich : ==");
            }
            if (p3.Equals(p2))
            {
                Console.WriteLine("p1 und p2 sind gleich : Equals()");
            }
            else
            {
                Console.WriteLine("p1 und p2 sind nicht gleich : Equals()");
            }
            */
            //Klasse SingelLinkedList testen
            //generische Classe verwenden
            // SingleLinkedListItem<Person> item = new SingleLinkedListItem<Person>(p, null);
            // Console.WriteLine(item);

            //Klasse SLL testen
            /*
            //Methode Add() testen
            SingleLinkedList<Person> singleLL = new SingleLinkedList<Person>();
            if(singleLL.Add(p))
            {
                Console.WriteLine("Person wurde hinzugefüt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden");
            }
            if (singleLL.Add(new Person("Tobias", "Flöckinger", new DateTime(2000, 8, 12))))
            {
                Console.WriteLine("Person wurde hinzugefügt!");
            }
            else
            {
                Console.WriteLine("Person konnte nicht hinzugefügt werden!");
            }



        Console.WriteLine("komplette SLL ausgegeben");
            Console.WriteLine(singleLL);
            */
            /*
            Person p = new Person("Eias", "Rist", new DateTime(2000, 4, 24));
            Person p2 = new Person("Christian", "Hölbling", new DateTime(2000, 4, 24));
            Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));
            Person p4 = new Person("Thomas", "Mairer", new DateTime(2000, 4, 24));

            SingleLinkedList<Person> sll = new SingleLinkedList<Person>();
            if(sll.Remove(null))
            {
                Console.WriteLine("Person wurde Entfernt");
            }else
            {
                Console.WriteLine("Person wurde nicht wntfernt - Parameter entfernt");
            }

            if (sll.Remove(p))
            {
                Console.WriteLine("Person wurde Entfernt");
            }
            else
            {
                Console.WriteLine("Person wurde nicht wntfernt - Liste ist leer");
            }


            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);

            //1.Fall
            if (sll.Remove(p3))
            {
                Console.WriteLine("Person wurde Entfernt- Fall2");
            }
            else
            {
                Console.WriteLine("Person wurde nicht wntfernt - Fall1");
            }
            Console.WriteLine(sll);

    */
            Person p = new Person("Eias", "Rist", new DateTime(2000, 4, 24));
            Person p2 = new Person("Christian", "Hölbling", new DateTime(2000, 4, 24));
            Person p3 = new Person("Tobias", "Flöckinger", new DateTime(2000, 4, 24));
            Person p4 = new Person("Thomas", "Mairer", new DateTime(2000, 4, 24));
            Person p5 = new Person("Marko", "Bekarevic", new DateTime(2000, 4, 24));
            Person p6 = new Person("Fabian", "Egger", new DateTime(2000, 4, 24));
            Person p7 = new Person("Alexander", "Fagschlunger", new DateTime(2000, 4, 24));
            Person p8 = new Person("Raphael", "Garzaner", new DateTime(2000, 4, 24));
            Person p9 = new Person("Lukas", "Heber", new DateTime(2000, 4, 24));


            SingleLinkedList<Person> sll = new SingleLinkedList<Person>();
           
            sll.Add(p);
            sll.Add(p2);
            sll.Add(p3);
            sll.Add(p4);
            sll.Add(p5);
            sll.Add(p6);
            sll.Add(p7);
            sll.Add(p8);
            sll.Add(p9);
            
            Console.WriteLine(sll);

            
            if(sll.Change(p, new Person("neuer Elisa", "neuer Rist", new DateTime(2000, 5, 25))) == false)
            {
                Console.WriteLine("Person nicht gefunden oder Liste ist leer");
                Console.WriteLine(sll);
            }else
            {
                Console.WriteLine("Alles geändert!");
                Console.WriteLine(sll);
            }

            /*
            bool istStarteintrag;
            SingleLinkedListItem<Person> finder = new SingleLinkedListItem<Person>();
            finder = sll.FindItemBeforeItem(p3,out istStarteintrag);

            if(istStarteintrag == true)
            {
                Console.WriteLine("Es ist der Starteintrag");
            }

            if(finder != null)
            {
                Console.WriteLine(finder);
            }else
            {
                Console.WriteLine("Die Person ist nicht vorhanden");
            }

            /*
             * finder =  sll.Find(p)
            if (finder == null)
            {
                Console.WriteLine("Item nicht gefunden");
            }
            else
            {
                Console.WriteLine(finder);
            }
            */
            Console.ReadKey();

            

        }
    }
}
