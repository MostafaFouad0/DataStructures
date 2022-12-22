using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class DoubleLinkedList
    {
        Node head;
        public void add_Front(int val) {
            Node tmp = new Node(val);

            if (head == null) {
                head = tmp;
                return;
            }
            tmp.nxt= head;
            head.prev= tmp;
            head = tmp;
        }
        public void Print() {
            Node runner = head;
            while (runner != null) {
                Console.Write(runner.data+" ");
                runner = runner.nxt;
            }
            Console.WriteLine();
        }
        public void add_Back(int val) {
            Node tmp=new Node(val);
            if (head == null) { 
                head= tmp;
                return;
            }
            Node q = head;
            while (q.nxt != null) {
                q = q.nxt;
            }
            q.nxt= tmp;
            tmp.prev= q;
        }
        public void add_after(int val,int item) {
            Node tmp = new Node(val);
            Node q= head;
            while (q != null) {

                if (q.data == item && q.nxt != null)
                {
                    tmp.prev = q;
                    tmp.nxt = q.nxt;
                    q.nxt.prev = tmp;
                    q.nxt = tmp;
                    return;
                }
                q = q.nxt;
            }
        }
        public void add_before(int val,int item) {
            Node tmp = new Node(val);
            Node q = head;
            while (q.nxt != null) {
                if (q.nxt.data == item) {
                    tmp.nxt = q.nxt;
                    tmp.prev = q;
                    tmp.nxt.prev= tmp;
                    tmp.prev.nxt = tmp;
                    return;
                }
                q = q.nxt;
            }
        }
        public void Delete_First_Node() {
            if (head == null) {
                Console.WriteLine("List Is Empty");
                return;
            }
            if (head.nxt == null) {
                head = null;
                return;
            }
            head=head.nxt;
            head.prev = null;
        }
        public void DeleteNode(int val) {
            Node q = head;
            while (q != null) {
                if (q.data == val) {
                    q.prev.nxt = q.nxt;
                    q.prev = null;
                    q.nxt= null;
                    return;
                }
                q = q.nxt;
            }
        }
        public void DeleteLastNode() {
            Node q = head;
            while (q.nxt != null) {
               q=q.nxt;
            }
            q.prev.nxt=null;    
        }
        public void reverse() {
            Node p1 = head;
            Node p2 = p1.nxt;
            p1.nxt = null;
            p1.prev = p2;
            while (p2 != null) {
                p2.prev = p2.nxt;
                p2.nxt = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            head = p1;
        
        }
    }
}
