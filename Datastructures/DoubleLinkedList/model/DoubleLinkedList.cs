using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.model

{
    class DoubleLinkedList<T> where T : class
    {
        private DoubelLinkedListItem<T> _lastItem;
        private DoubelLinkedListItem<T> _firstItem;
        public DoubleLinkedList()
        {
            this._firstItem = null;
            this._lastItem = null;
        }

        public DoubleLinkedList(T item)
        {
            this._firstItem = new DoubelLinkedListItem<T>(item, null, null);
            this._lastItem = _firstItem;
        }

        public DoubleLinkedList(DoubleLinkedList<T> dll)
        {
            this._firstItem = dll._firstItem;
            this._lastItem = dll._lastItem;
        }

        public bool Add(T itemToAdd)
        {
            if (itemToAdd == null)
            {
                return false;
            }

            //1. Fall: das erste Item in der Liste

            if (_firstItem == null)
            {
                _firstItem = new DoubelLinkedListItem<T>(itemToAdd, null, null);
                _lastItem = _firstItem;
                return true;
            }
            else
            {
                DoubelLinkedListItem<T> toAdd = new DoubelLinkedListItem<T>(itemToAdd, _lastItem, null);
                this._lastItem.nextItem = toAdd;
                this._lastItem = toAdd;
                return true;
            }
        }

        public DoubelLinkedListItem<T> Find (T itemToFind, out bool isStartItem)
        {
            isStartItem = false;
            if(itemToFind == null)
            {
                return null;
            }
            if(_firstItem == null)
            {
                return null;
            }

            //1. Fall Object ist erster Eintrag

            if(this._firstItem.Item.Equals(itemToFind))
            {
                isStartItem = true;
                return _firstItem;
            }

            //2. Fall: irgendwo

            DoubelLinkedListItem<T> actItem = _firstItem;
            while(actItem != null)
            {
                if(actItem.Item.Equals(itemToFind))
                {
                    return actItem;
                }
                actItem = actItem.nextItem;
            }
            return null;
            
            

        }

        public bool Remove(T itemToRemove)
        {
            DoubelLinkedListItem<T> chosenOne = Find(itemToRemove, out bool isStartItem);

            if(itemToRemove == null)
            { return false; }

            //1. Fall: Erstes Element wird entfernt

            if (isStartItem)
            {
                _firstItem.nextItem.ItemBefore = null;
                _firstItem = _firstItem.nextItem;
                return true;
            }
            else //2.Fall irgendwo in der Mitte
            {
                if (chosenOne.nextItem == null) //3.Fall: das Element am Ende wird entfernt
                {
                    chosenOne.ItemBefore.nextItem = null;
                }
                else
                {
                   chosenOne.ItemBefore.nextItem = chosenOne.nextItem;
                   chosenOne.nextItem.ItemBefore = chosenOne.ItemBefore;
                 return true;
                }
            }
            return false;

        }
        
        public bool Change(T itemToChange, T newItem)
        {
            if(itemToChange == null)
            {
                return false;
            }
            bool isStartItem;
            DoubelLinkedListItem<T> chosenOne = Find(itemToChange,out isStartItem);
            DoubelLinkedListItem<T> actItem = this._firstItem;


            while(actItem != null)
            {
                if(chosenOne.Item.Equals(actItem.Item))
                {

                    actItem.Item = newItem;
                }
                actItem = actItem.nextItem;
            }
            return false;
        }
        public override string ToString()
        
            {

                string s = "";

                if (this._firstItem != null)
                {
                    DoubelLinkedListItem<T> actItem = this._firstItem;
                    while (actItem != null)
                    {
                        s += actItem.Item.ToString() + "\n";
                        actItem = actItem.nextItem;
                    }
                }

                if (s == "")
                {
                    return " no Item";
                }

                return s;
            }

        public bool AddItemAfterItem(T itemToAdd, T targetItem)
        {
            if ((itemToAdd == null) || (targetItem == null))
            {
                return false;
            }

            bool isStartItem;
            DoubelLinkedListItem<T> chosenOne = Find(targetItem, out isStartItem);
            DoubelLinkedListItem<T> toAddItem = new DoubelLinkedListItem<T>(itemToAdd,null,null);
            DoubelLinkedListItem<T> actItem = _firstItem;
            
            while(actItem != null)
            {
                if(chosenOne.Item.Equals(actItem.Item))
                {
                    toAddItem.ItemBefore = actItem;
                    toAddItem.nextItem = actItem.nextItem;
                    actItem.nextItem = toAddItem;
                    actItem.nextItem.ItemBefore = toAddItem;
                    return true;
                }
                actItem = actItem.nextItem;
            }
            return false;
        }
        
        public DoubelLinkedListItem<T> FindRekursiv(T itemToFind, DoubelLinkedListItem<T> actItem = null)
        {
            if(itemToFind == null) //Parameter überpüfen
            {
                return null;
            }

            if(this._firstItem == null) //DLL leer ?
            {
                return null;
            }

            if(actItem == null) //actitem == null, bedeutet dass die find am Beginn der DLL starten soll
            {
                actItem = this._firstItem;
            }else //nach mehrmaligen aufruf, Zeiger aufs nächste Item setzen
            {
                actItem = actItem.nextItem;
            }

            if(actItem == null)//Ende der Liste ist erreicht , sonst wird auf actItem.nextItem gesetz
            {
                return null;
            }else if(actItem.Item.Equals(itemToFind)) // gesuchtes Item gefunden
            {
                return actItem;
            }
            else // Methode wird nocheinmal aufgerufen, mit actItem
            {
                return FindRekursiv(itemToFind, actItem);
            }
        }
    }
}
