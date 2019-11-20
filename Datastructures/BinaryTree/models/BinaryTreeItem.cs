using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeApp.models
{
    class BinaryTreeItem
    {
        public int? Item { get; set; }
        public int Counter { get; set; }
        public BinaryTreeItem ItemLeft { get; set; }
        public BinaryTreeItem ItemRight { get; set; }

        public BinaryTreeItem() : this(null, 1, null, null) { }
        public BinaryTreeItem(int? item, int counter, BinaryTreeItem leftItem, BinaryTreeItem rightItem)
        {
            this.Item = item;
            this.Counter = counter;
            this.ItemLeft = leftItem;
            this.ItemRight = rightItem;
        }

        public override string ToString()
        {
            return this.Item.ToString();
        }


    }
}
