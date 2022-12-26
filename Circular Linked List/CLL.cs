using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Node {
        public int data;
        public Node nxt;
        public Node(int data) { this.data = data; }
    }
    public class CLL {
        Node last;
       public  void add_end(int val) { 
        Node tmp=new Node(val);
            if (last == null) { 
            last= tmp;
                last.nxt = last;
                return;
            }
            tmp.nxt = last.nxt;
            last.nxt = tmp; 
            last= tmp;
        }
        public void remove_beg() { 
        last.nxt=last.nxt.nxt;
        }
        public void delete_last() { 
        Node q=last.nxt;
            while (q.nxt != last) {
                q = q.nxt;

            }
            q.nxt = last.nxt;
            last = q;
        }
        public void add_beg(int val) {
            Node tmp = new Node(val);
            if (last == null) {
                last = tmp;
                last.nxt = last;
                return;
            }
            tmp.nxt=last.nxt;   
            last.nxt = tmp; 
                  
        }
        public void print() {
            Node q = last.nxt;
            while (q != last) {

                Console.WriteLine(q.data);
                q = q.nxt;
            }
            Console.WriteLine(q.data);
        
        }
        public void conc(CLL l1,CLL l2) {
            Node tmp = l1.last.nxt;
            l1.last.nxt = l2.last.nxt;
            l2.last.nxt = tmp;
            l1.last = l2.last;
        }

    
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CLL l=new CLL();
            l.add_end(2);
            l.add_end(7);
            l.add_end(11);
            l.add_beg(100);
            l.print();
            Console.WriteLine("---------------------");
            CLL l2=new CLL();
            l2.add_end(2);
            l2.add_end(1000);
            l2.add_end(143);
            l2.print();
            l.conc(l, l2);
            Console.WriteLine("---------------------");
            l.print();

        }
    }
}
