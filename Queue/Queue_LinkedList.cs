using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_linkedList
{
    public class Node<T>{
        public T data;
       public Node<T>nxt;
        public Node(T data) {
            this.data = data;
            nxt = null;
        }
    }
    public class Queue<T> {
        Node<T> head;
        int count;
        public Queue(){
            count=0;
         }
        public bool is_empty() { 
            return head==null;
        }
        public void enqueue(T data) {
            //O(N)
            if (head == null) { 
                head = new Node<T>(data);
                count++;
                return;
            }
            Node<T> tmp =new Node<T>(data);
            Node<T> q = head;
            while (q.nxt != null) {
                q = q.nxt;
            }
            q.nxt = tmp;
            count++;
        }
        public T dequeue() {
            // O(1)
            if (is_empty()) { 
                return default(T);
            }
            T tmp = head.data;
            head = head.nxt;
            count--;
            return tmp;
        }
        public void print() {
            // O(N)
            if (is_empty()) {
                Console.WriteLine("Queue is empty");
                return;
             }
            Node<T> q = head;
            while (q != null) {
                Console.Write(q.data + " ");
                q = q.nxt;
            }
            Console.WriteLine();
        }
        public int get_count() {
            return count;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue < int > q= new Queue<int>();
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);
            Console.WriteLine(q.get_count());
            q.print();
            q.dequeue();
            q.print();
        }
    }
}
