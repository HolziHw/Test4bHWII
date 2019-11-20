using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedList.model
{
    class SingleLinkedListItem<T> where T : class
    {

        public T Item { get; set; }
        public SingleLinkedListItem<T> NextItem { get; set; } //verweis auf das nächste Item
        public SingleLinkedListItem() : this(null, null) { }
        public SingleLinkedListItem(T p, SingleLinkedListItem<T> nextItem)
        {
            this.Item = p;
            this.NextItem = nextItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }
    }
}
