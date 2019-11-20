using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BinaryTreeApp.models;

namespace BinaryTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            //  int? bti1 = 20, bti2 = 5, bti3 = 30, bti4 = 2, bti5 = 5;
            int? bti1 = 100, bti2 = 90, bti3 = 160, bti4 = 155, bti5 = 156;
            bt.Add(bti1);
            bt.Add(bti2);
            bt.Add(bti3);
            bt.Add(bti4);
            bt.Add(bti5);
            Console.ReadKey();
            bt.Remove(150);
            Console.ReadKey();
        }
    }
}
