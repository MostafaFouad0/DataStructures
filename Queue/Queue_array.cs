using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArr
{
    public class queue<T> {
        T[] data;
        int front;
        int back;
        int count;
        public queue(int size){
            front = -1;
            back = -1;
            count = 0;
            data = new T[size];
         }
        public bool is_empty() { 
            return front == -1 || front>back;
        }
        public bool is_Full() {
            return front + 1 == data.Length;
        }
        public void enqueue(T value) {
            if (is_Full()) {
                return;
            }
            if (front == -1) front++;
            data[++back] = value;
            count++;
        }
        public T dequeue() {
            if (is_empty()) { 
                return default(T);
            }
            return data[front++];
            count--;
        }
        public int get_count() {
            return count;
        }
        public void print() {
            if (is_empty()) {
                Console.WriteLine("Queue is Empty");
                return;
            }
            for (int i = front; i <=back; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            queue<int> q=new queue<int>(3);
            q.enqueue(1);
            q.enqueue(2);
            q.enqueue(3);
            q.print();
            q.dequeue();
            q.print();

        }
    }
}
