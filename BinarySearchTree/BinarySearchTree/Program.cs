using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        public class BinarySearchTree
        {
            private t_node root = null;
            // public int v;

            private void printree(t_node cn)
            {
                if (cn == null)
                {
                    return;
                }
                printree(cn.left);
                Console.WriteLine(cn.t_value);
                printree(cn.right);
               
            }
            public void print()
            {
                printree(root);
               
            }
            public void Add(int v)
            {
                if (root == null)
                {
                    root = new t_node(v);
                }
                else
                {
                    t_node cn = root;
                    while (true)
                    {
                        if (cn.t_value > v)
                        {
                            if (cn.left == null)
                            {
                                cn.left = new t_node(v);
                                return;
                            }
                            else
                            {
                                cn = cn.left;
                            }
                        }
                        else
                            if (cn.right == null)
                        {
                            cn.right = new t_node(v);
                            return;
                        }
                        else
                        {
                            cn = cn.right;
                        }
                    }
                }
            }
        }




        static void Main(string[] args)
        {
            BinarySearchTree bnew = new BinarySearchTree();


            Random rnnumbers = new Random();
            int[] numbers = new int[100];
            //t_node t1 = new t_node();
            for (int i = 0; i < 100; i++)
            {

                numbers[i] = rnnumbers.Next(100);
                bnew.Add(numbers[i]);


            }
            bnew.print();

            Console.ReadKey();
        }
    }
}
