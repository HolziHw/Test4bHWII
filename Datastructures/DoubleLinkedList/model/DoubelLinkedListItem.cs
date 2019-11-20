using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList.model

{
    class DoubelLinkedListItem<T> where T: class
    {

        public T Item { get; set; }

        public DoubelLinkedListItem<T> nextItem { get; set; }

        public DoubelLinkedListItem<T> ItemBefore { get; set; }

        public DoubelLinkedListItem() : this(null, null, null) { }

        public DoubelLinkedListItem(T p, DoubelLinkedListItem<T> ItemBefore, DoubelLinkedListItem<T> nextItem)
        {
            this.Item = p;
            this.ItemBefore = ItemBefore;
            this.nextItem = nextItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }


    }
}
