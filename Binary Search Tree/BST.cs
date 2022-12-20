using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Node
    {
       public Node left;
       public int data;
       public Node right;
        public Node(int data)
        { 
        this.data = data;
            left = null;
            right = null;
        }
    }
    public class Tree
    {
       public Node root;
      public  void addHelper(Node root,int data)
        {
            if (root.data > data) 
            {
                if (root.left == null) 
                { 
                    root.left = new Node(data);
                    return;
                }
                addHelper(root.left,data);
                return;
            }
            if (root.right == null) 
            { 
                root.right= new Node(data); 
                return;
            }
            addHelper(root.right, data); 
        }
       public void add(int data)
        {
            if (root == null) 
            { 
                root = new Node(data);
                return;
            }
            addHelper(root,data);
        }
        void printHelper(Node root) {
            if (root == null)
            {
                return;
            }
            printHelper(root.left);
            Console.WriteLine(root.data);
            printHelper(root.right);

        }
       public void print()
        {
            printHelper(root);
        }
       public bool Search(int data)
        {
            Node q = root;
            while (q != null) 
            {
                if (q.data > data)
                {
                    q = q.left;
                }
                else if (q.data < data)
                {
                    q = q.right;
                }
                else 
                {
                    return true;
                }
            }
            return false;
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree t=new Tree();
            t.add(2);
            t.add(10);
            t.add(23);
            t.add(13);
            t.add(1);
            t.print();
            Console.WriteLine(t.Search(70));
        }
    }
}
