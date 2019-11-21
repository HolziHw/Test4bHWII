using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeApp.models
{
    class BinaryTree
    {
        private int keineZahl;
        private double auchKeineZahl;
        private BinaryTreeItem _root;
        private int _count;

        public BinaryTree()
        {
            this._root = null;
        }
        public BinaryTree(int? item)
        {
            this._root = new BinaryTreeItem(item, 0, null, null);
        }
        public BinaryTree(BinaryTree list)
        {
            this._root = list._root;
        }

        //Methoden
        public int Count
        {
            get
            {
                return _count;
            }
        }


        public void Add(int? itemToAdd, BinaryTreeItem actItem = null)
        {
            BinaryTreeItem newItem = new BinaryTreeItem(itemToAdd, 1, null, null);

            if (itemToAdd == null)
            {
                return;
            }
            if (_root == null)
            {
                _root = newItem;
            }
            if (actItem == null)
            {
                actItem = _root;
            }

            if (actItem.Item == itemToAdd)
            {
                _count++;
            }
            else if (actItem.Item < itemToAdd)
            {
                if (actItem.ItemRight != null)
                {
                    actItem = actItem.ItemRight;
                    Add(itemToAdd, actItem);

                }
                else
                {
                    actItem.ItemRight = newItem;
                }

            }
            else
            {
                if (actItem.ItemLeft != null)
                {
                    actItem = actItem.ItemLeft;
                    Add(itemToAdd, actItem);
                }
                else
                {
                    actItem.ItemLeft = newItem;
                }
            }
            /*
            if (itemToAdd == 0)
            {
                return;
            }

            //1.Fall: Tree ist leer:
            if (_root == null)
            {
                _root = new BinaryTreeItem(itemToAdd, 1, null, null);
                _count++;
            }
            else
            {
                BinaryTreeItem actItemPrevious = null;
                BinaryTreeItem actItem = _root;


                while (actItem != null)
                {
                    //2.Fall: ItemToAdd = actItem
                    if (itemToAdd == actItem.Item)
                    {
                        actItem.Counter++;
                        _count++;
                        return;
                    }

                    actItemPrevious = actItem;

                    //3.Fall: itemToAdd > actItem
                    if (itemToAdd > actItem.Item)
                    {
                        actItem = actItem.ItemRight;
                    }
                    //4.Fall: itemToAdd <= actItem
                    else
                    {
                        actItem = actItem.ItemLeft;
                    }
                }

                if (actItemPrevious.Item < itemToAdd)
                {
                    actItemPrevious.ItemRight = new BinaryTreeItem(itemToAdd, 1, null, null);
                    _count++;
                }
                else
                {
                    actItemPrevious.ItemLeft = new BinaryTreeItem(itemToAdd, 1, null, null);
                    _count++;
                }


            }



            //ToString()

        */
        }
        public BinaryTreeItem Find(int? itemToFind, BinaryTreeItem actItem = null)
        {

            if (_root == null)
            {
                return null;
            }

            if (actItem == null)
            {
                actItem = _root;
            }


            if (actItem.Item < itemToFind)
            {
                if (actItem.ItemRight == null)
                {
                    return null;
                }
                actItem = actItem.ItemRight;
                return Find(itemToFind, actItem);
            }
            else if (actItem.Item > itemToFind)
            {
                if (actItem.ItemLeft == null)
                {
                    return null;
                }
                actItem = actItem.ItemLeft;
                return Find(itemToFind, actItem);
            }
            else
            {
                return actItem;
            }
            /*
            BinaryTreeItem actItem = _root;

            while(actItem != null)
            {
                if(actItem.Item == itemToFind)
                {
                    return actItem;
                }
               
                if(itemToFind > actItem.Item)
                {
                    actItem = actItem.ItemRight;
                }
                else if(itemToFind < actItem.Item)
                {
                    actItem = actItem.ItemLeft;
                }

            }

            return null;
        */
        }
        public BinaryTreeItem FindItemBefore(double? itemToFind)
        {
            BinaryTreeItem itemBefore = null;
            if (itemToFind == null)
            {
                return null;
            }

            if (this._root == null)
            {
                return null;
            }
            if (this._root.Item == itemToFind)
            {
                return null;
            }

            BinaryTreeItem actItem = this._root;

            while (actItem != null)
            {
                if (itemToFind > actItem.Item)
                {
                    if (actItem.ItemRight.Item == itemToFind)
                    {
                        itemBefore = actItem;
                        return itemBefore;
                    }
                    else
                    {
                        actItem = actItem.ItemRight;
                    }
                    if (itemToFind < actItem.Item)
                    {
                        if (actItem.ItemLeft.Item == itemToFind)
                        {
                            itemBefore = actItem;
                            return itemBefore;
                        }
                        else
                        {
                            actItem = actItem.ItemLeft;
                        }
                    }
                    if (actItem.ItemLeft == null || actItem.ItemRight == null)
                    {
                        return null;
                    }


                }


            }
            return null;
        }
        /*public BinaryTreeItem FindBefore(int? itemToFind, BinaryTreeItem actItem = null)
        {

            if (_root == null)
            {
                return null;
            }

            if (actItem == null)
            {
                actItem = _root;
            }

            if ((actItem.ItemLeft.Item == itemToFind) || (actItem.ItemRight.Item == itemToFind))
            {
                return actItem;
            }
            else
            {
                if (actItem.Item < itemToFind)
                {
                    actItem = actItem.ItemRight;
                    return FindBefore(itemToFind, actItem);
                }
                else
                {
                    actItem = actItem.ItemLeft;
                    return FindBefore(itemToFind, actItem);
                }

            }

        }
        */
        public BinaryTreeItem Minimum(int? itemToFind = null, BinaryTreeItem actItem = null)
        {

            if (_root == null)
            {
                return null;
            }

            if (actItem == null)
            {
                if (itemToFind != null)
                {
                    actItem = Find(itemToFind.Value);
                }
                else
                {
                    actItem = _root;
                }

            }
            else
            {
                actItem = actItem.ItemLeft;
            }


            if (actItem.ItemLeft == null)
            {
                return actItem;
            }
            else
            {
                return Minimum(itemToFind, actItem);
            }
            /*
            BinaryTreeItem actItem = _root;
            if(actItem == null)
            {
                return null;
            }

            if (itemToFind != null)
            {
                actItem = Find(itemToFind);
            }

            while (actItem != null)
            {
                if (actItem.ItemLeft == null)
                {
                    return actItem;
                }
                actItem = actItem.ItemLeft;
            }

            return null;
            */
        }
        public BinaryTreeItem Maximum(int? itemToFind, BinaryTreeItem actItem = null)
        {
            if (_root == null)
            {
                return null;
            }

            if (actItem == null)
            {
                if (itemToFind != null)
                {
                    while (actItem.Item < itemToFind)
                    {
                        actItem = actItem.ItemRight;
                    }
                }
                actItem = _root;
            }
            else
            {
                actItem = actItem.ItemRight;
            }

            if (actItem.ItemRight == null)
            {
                return actItem;
            }
            else
            {
                return Maximum(itemToFind, actItem);
            }

            /*
            while (actItem != null)
            {
                if (actItem.ItemRight == null)
                {
                    return actItem;
                }
                actItem = actItem.ItemRight;
            }

            return null;
            */
        }
        public void Ausgabe()
        {
            Ausgabe();
            Ausgabe();
        }
        public BinaryTreeItem MinimumBefore(int? itemToFind = null)
        {
            BinaryTreeItem actItem = _root;
            if (actItem == null)
            {
                return null;
            }

            if (itemToFind != null)
            {
                actItem = Find(itemToFind);
            }

            while (actItem != null)
            {
                if (actItem.ItemLeft.ItemLeft == null)
                {
                    return actItem;
                }
                actItem = actItem.ItemLeft;
            }

            return null;

        }
        public bool Remove(int? itemToRemove)
        {
            if ((this._root == null) || (itemToRemove == null))
            {
                return false;
            }

            BinaryTreeItem itemBefore;

            BinaryTreeItem treeItemToRemove = Find(itemToRemove);
            itemBefore = FindItemBefore(itemToRemove);

            if ((itemBefore == null) || (treeItemToRemove == null))
            {
                return false;
            }

            if (treeItemToRemove.Counter > 1)
            {
                treeItemToRemove.Counter--;
                return true;
            }
            else
            {
                //Fall a:
                if ((treeItemToRemove.ItemLeft == null) && (treeItemToRemove.ItemRight != null))
                {
                    if (itemBefore.ItemRight == treeItemToRemove)
                    {
                        itemBefore.ItemRight = treeItemToRemove.ItemRight;
                        return true;
                    }
                    else
                    {
                        itemBefore.ItemLeft = treeItemToRemove.ItemRight;
                        return true;
                    }
                }
                //Fall b:
                else if (treeItemToRemove.ItemRight == null && treeItemToRemove.ItemLeft != null)
                {
                    if (itemBefore.ItemRight == treeItemToRemove)
                    {
                        itemBefore.ItemRight = treeItemToRemove.ItemLeft;
                        return true;
                    }
                    else if (itemBefore.ItemLeft == treeItemToRemove)
                    {
                        itemBefore.ItemLeft = treeItemToRemove.ItemLeft;
                        return true;
                    }
                }

                //Fall c:
                else if (treeItemToRemove.ItemRight.ItemLeft == null)
                {
                    if (itemBefore.ItemRight == treeItemToRemove)
                    {
                        itemBefore.ItemRight = treeItemToRemove.ItemRight;
                        treeItemToRemove.ItemRight.ItemLeft = treeItemToRemove.ItemLeft;
                        return true;
                    }
                    else if (itemBefore.ItemLeft == treeItemToRemove)
                    {
                        itemBefore.ItemLeft = treeItemToRemove.ItemRight;
                        treeItemToRemove.ItemRight.ItemLeft = treeItemToRemove.ItemLeft;
                        return true;
                    }
                }

                //Fall d:
                else
                {
                    if (itemBefore.ItemRight == treeItemToRemove)
                    {
                        BinaryTreeItem treeItemToRemoveMinimumBefore = MinimumBefore(itemToRemove);
                        itemBefore.ItemRight = treeItemToRemoveMinimumBefore.ItemLeft;
                        treeItemToRemoveMinimumBefore.ItemLeft = itemBefore.ItemRight.ItemRight;
                        itemBefore.ItemRight.ItemRight = treeItemToRemove.ItemRight;
                        itemBefore.ItemRight.ItemLeft = treeItemToRemove.ItemLeft;
                        return true;
                    }
                    else if (itemBefore.ItemLeft == treeItemToRemove)
                    {
                        BinaryTreeItem treeItemToRemoveMinimumBefore = MinimumBefore(itemToRemove);
                        itemBefore.ItemLeft = treeItemToRemoveMinimumBefore.ItemLeft;
                        treeItemToRemoveMinimumBefore.ItemLeft = itemBefore.ItemLeft.ItemRight;
                        itemBefore.ItemLeft.ItemRight = treeItemToRemove.ItemRight;
                        itemBefore.ItemLeft.ItemLeft = treeItemToRemove.ItemLeft;
                        return true;
                    }
                }

            }
            return false;
        }
        /*public bool Remove(int itemToRemove)
        {

            if (_root == null)
            {
                return false;
            }
            BinaryTreeItem itemBefore = FindBefore(itemToRemove, _root);
            BinaryTreeItem actItem = _root;

            while (actItem != null)
            {
                if (actItem.Item == itemToRemove)
                { 
                   //1. Fall
                   if(actItem.ItemLeft == null)
                    {
                        if(itemBefore.ItemLeft.Item == actItem.Item)
                        {
                            itemBefore.ItemLeft = actItem.ItemRight;
                            return true;
                        }else
                        {
                            itemBefore.ItemRight = actItem.ItemRight;
                            return true;
                        }
                    }
                   //2. Fall
                   if(actItem.ItemRight == null)
                   {
                        if(itemBefore.ItemLeft.Item == actItem.Item)
                        {
                            itemBefore.ItemLeft = actItem.ItemLeft;
                            return true;
                        }else
                        {
                            itemBefore.ItemRight = actItem.ItemLeft;
                            return true;
                        }
                   }
                   //3. Fall
                   if((actItem.ItemLeft != null)&&(actItem.ItemLeft != null)&&(actItem.ItemRight.ItemLeft == null))
                    {
                        if(itemBefore.ItemRight.Item == actItem.Item)
                        {
                            actItem.ItemRight.ItemLeft = actItem.ItemLeft;
                            itemBefore.ItemRight = actItem.ItemRight;
                            return true;
                        }else
                        {
                            actItem.ItemRight.ItemLeft = actItem.ItemLeft;
                            itemBefore.ItemLeft = actItem.ItemRight;
                            return true;

                        }
                    }
                }
                if(actItem.Item > itemToRemove)
                {
                    actItem = actItem.ItemLeft;
                }
                if(actItem.Item < itemToRemove)
                {
                    actItem = actItem.ItemRight;
                }
                // 4.Fall

            }
            return false;
        }
    }*/
        public int Count2
        {
            get
            {
                return _count;
            }
        }
    }
    public int Count22
        {
            get
            {
                return _count;
            }
        }
}
