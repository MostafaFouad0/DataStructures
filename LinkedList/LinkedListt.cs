
public class Node {
       public int Data;
       public Node nxt;
       public Node(int Data) {
            this.Data = Data;
            this.nxt = null;
        }
    }
    class LinkedList{
        Node start;
       public void print() {
            Node runner = start;
            while (runner != null) {
                Console.Write(runner.Data + " ");
                runner = runner.nxt;  
            }
            Console.WriteLine();
        }
        public void insert_at_begining(int data) { 
            Node tmp=new Node(data);
            tmp.nxt = start;
            start = tmp;
        }

        public void insert_at_end(int data) { /// O(N) where N is the number of items in the List
            Node tmp = new Node(data);
            if (start == null) { 
                start = tmp;
                return;
            }
            Node runner=start;
            while (runner.nxt != null) { 
                runner=runner.nxt;
            }
            runner.nxt = tmp;   
        }
        public void search(int data) {
            /// O(N)
            Node runner = start;
            int idx = 0;
            while (runner != null) {
                if (runner.Data == data) {
                    Console.WriteLine("Elemnet Found At Position " + ++idx);
                    return;
                }
                idx++;
                runner= runner.nxt; 
            }
            Console.WriteLine("Element Not Found in the List");
        }
        public void insert_After_(int data,int item) {
            Node tmp = new Node(data);
            Node runner = start;
            while (runner != null) {
                if (runner.Data == item) { 
                    tmp.nxt=runner.nxt;
                    runner.nxt = tmp;
                    return;
                }
                runner= runner.nxt;
            }
            Console.WriteLine("This Item not in the List");
        }
        public void insert_Before_(int data,int item) {
            /// O(N)
            Node tmp = new Node(data);
            if (start == null) {
                Console.WriteLine("List is Empty");
                return;
            }
            if (item == start.Data) {
                tmp.nxt = start;
                start= tmp;
                return;
            }
            Node runner = start;
            while (runner != null) {
                if (runner.nxt.Data == item) {
                    tmp.nxt = runner.nxt;
                    runner.nxt= tmp;
                    return;
                }
                runner = runner.nxt;
            }
            Console.WriteLine("Item is not in the list");
        }

        public void Reverse_List() {
            /// O(N)
            Node prev, ptr, next;
            prev = null;
            ptr= start;
            while (ptr != null) {
                next = ptr.nxt;
                ptr.nxt = prev;
                prev= ptr;
                ptr= next;
            }
            start = prev;
        }
        public void DeleteNode(int data) {
            if (start == null) {
                Console.WriteLine("List is Empty");
                return;
            }
            if (start.Data == data) { 
                start=start.nxt;
                return;
            }
            Node runner = start;
            while (runner.nxt != null) {
                if (runner.nxt.Data == data) { 
                    runner.nxt= runner.nxt.nxt;
                    return;
                }
                runner= runner.nxt;
            }
            Console.WriteLine("Item not in the list");
        }   
}
