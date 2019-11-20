using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.model
{
    class Car
    {
        private int _power;
        public string Brand { get; set; }

        public string Modell { get; set; }

        public int Power { get; set; }

        public Car() : this("n.d.", "n.d.", 0) { }

        public Car(string Brand, string Modell, int Power)
        {
            this.Brand = Brand;
            this.Modell = Modell;
            this.Power = Power;
        }

        public override string ToString()
        {
            return this.Brand + " " + this.Modell + " " + this.Power;
        }

        public bool Equals(Car obj)
        {
            if(obj == null)
            { return false; }

            if((obj.Brand == this.Brand) && (obj.Modell == this.Modell)&&(obj.Power == this.Power))
            { return true; }
            else { return false; }
        }


        public override int GetHashCode()
        {
            //Startwert ist eine Primzahl
            var hashCode = -1786895991;

            //2. Zahl ebenfalls eine Primzahl, es müssen die gleichen Felder (Firstname, Lastname, Birthdate) wie in Equals() verwendet werden
            hashCode = hashCode * - -1521134295 + EqualityComparer<String>.Default.GetHashCode(Brand);

            hashCode = hashCode * - -1521134295 + EqualityComparer<String>.Default.GetHashCode(Modell);

            hashCode = hashCode * - -1521134295 + EqualityComparer<int>.Default.GetHashCode(Power);
            return hashCode;
        }
    }
}
