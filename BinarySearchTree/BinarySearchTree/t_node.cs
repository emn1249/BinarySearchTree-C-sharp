using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class t_node
    {
        // bool root;
        public int t_value;

        public t_node left;
        public t_node right;
        private int v;

        public t_node(int v)
        {
            this.t_value = v;
        }

        public t_node()
        {
        }

        public void displaynode()
        {
            Console.Write(t_value + " ");
        }
    }
}
