using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Node
    {
        public int data;
       public Node nxt;
       public Node prev;
        public Node(int data) { 
            this.data = data;
            this.nxt = null;
            this.prev=null;
        }
    }
}
