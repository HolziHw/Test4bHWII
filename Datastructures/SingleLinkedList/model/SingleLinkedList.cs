using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.model
{
    class SingleLinkedList<T> where T : class
    {        //generic
        private SingleLinkedListItem<T> _firstItem;
        private SingleLinkedListItem<T> _lastItem;

        public SingleLinkedList()
        {
            this._firstItem = null;
            this._lastItem  = null;
        }

        public SingleLinkedList(T item)
        {
            this._firstItem = new SingleLinkedListItem<T>(item, null);
            this._lastItem = _firstItem;
        }

        public SingleLinkedList(SingleLinkedList<T> sll)
        {
            this._firstItem = sll._firstItem;
            this._lastItem = sll._lastItem;
        }

        //Methode Add
        public bool Add(T itemToAdd)
        {
            //1.Parameter überprüfen
            if (itemToAdd == null)
            {
                return false;
            }

            //1.Fall: die SingleLinkedList ist leer
            if (this._firstItem == null)
            {
                this._firstItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._firstItem;
            }

            //2.Fall: die SLL ist nicht leer
            else
            {
                this._lastItem.NextItem = new SingleLinkedListItem<T>(itemToAdd, null);
                this._lastItem = this._lastItem.NextItem;
            }
            return true;

        }

        public bool Remove (T itemToRemove)
        {

            bool isStart;
            SingleLinkedListItem<T> foundItem = new SingleLinkedListItem<T>();

            foundItem = FindItemBeforeItem(itemToRemove,out isStart);
            
            if((isStart == true)&&(foundItem == null))
            {
                _firstItem = _firstItem.NextItem;
                return false;
            }

            if(foundItem == null)
            {
                Console.WriteLine("Die Person ist nicht vorhanden");
                return false;
            }
            else
            {
                foundItem.NextItem = foundItem.NextItem.NextItem;
                return true;
            }
            /*
            if(itemToRemove == null)
            {
                return false;
            }
            if(this._firstItem == null)
            {
                //Liste ist leer
                return false;
            }
            
            //1ster Fall
            //1ter Eintrag ist der gesuchte
            if(itemToRemove.Equals(this._firstItem.Item))
            {
                this._firstItem = this._firstItem.NextItem;
                return true;
            }

            //2ter Fall
            //irgendwo zw. first und lastitem
            SingleLinkedListItem<T> actItem = this._firstItem;
            while(actItem != null)
            {
                if (actItem.NextItem != null)
                {
                    if (actItem.NextItem.Item.Equals(itemToRemove))
                    {
                        actItem.NextItem = actItem.NextItem.NextItem;
                        return true;
                    }

                }
                actItem = actItem.NextItem;
            }

            //3ter Fall
            //letztes Item
            actItem = this._firstItem;
            while (actItem != this._lastItem)
            {
                actItem = actItem.NextItem;
            }

            if (actItem.NextItem.Item.Equals(itemToRemove))
            {
                this._lastItem = actItem;
                this._lastItem.NextItem = null;
                return true;
            }
            return false;

            */

            


        }

        public SingleLinkedListItem<T> Find(T itemToFind)
        {
            if(itemToFind == null)
            {
                return null;
            }
            if(this._firstItem == null)
            {
                return null;
            }
            SingleLinkedListItem<T> actItem = new SingleLinkedListItem<T>();
            actItem = this._firstItem;
            while(actItem != null)
            {
                if(actItem.Item.Equals(itemToFind))
                {
                    return actItem;
                }
                else
                {
                    actItem = actItem.NextItem;
                }
            }
            return null;
        }
        
        public SingleLinkedListItem<T> FindItemBeforeItem(T itemToFind, out bool StartItem)
        {
            StartItem = false;
            if (itemToFind == null)
            {
                return null;
            }
            if (this._firstItem == null)
            {
                return null;
            }

            //Fall1: erstes Item ist gesuchtes Item

            if(this._firstItem.Item.Equals(itemToFind))
            {
                StartItem = true;
                return null;
            }

            SingleLinkedListItem<T> actItem = new SingleLinkedListItem<T>();
            actItem = this._firstItem;
            while (actItem != null)
            {
                if ((actItem.NextItem.Item.Equals(itemToFind))&&(actItem.NextItem != null))
                {
                    return actItem;
                }
                actItem = actItem.NextItem;
            }
            return null;

        }
        
        public override string ToString()
            {
            
                string s = "";

                if(this._firstItem != null)
                {
                    SingleLinkedListItem<T> actItem = this._firstItem;
                    while(actItem != null)
                    {
                        s += actItem.Item.ToString() + "\n";
                        actItem = actItem.NextItem;
                    }
                }

                if(s == "")
                {
                    return " no Item";
                }

                return s; 
            }

        public bool Change (T itemToChange, T itemNewData)
        {
            if((itemToChange == null)||(this._firstItem == null))
            {
                return false;
            }

            SingleLinkedListItem<T> foundItem = Find(itemToChange);

            //1. Nicht vorhanden

            if(foundItem == null)
            {
                return false;
            }
            else
            {
                foundItem.Item = itemNewData;
                return true;
            }

        }
        
    }

}
